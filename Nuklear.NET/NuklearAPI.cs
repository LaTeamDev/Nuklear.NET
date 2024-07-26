using System.Numerics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Nuklear.NET {
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void FontStashAction(IntPtr atlas);

    public static unsafe class NuklearApi {
        public static NkContext* Ctx;
        public static NuklearDevice Dev;

        static NkAllocator* _allocator;
        static NkFontAtlas* _fontAtlas;
        static NkDrawNullTexture* _nullTexture;
        static NkConvertConfig* _convertCfg;

        static NkBuffer* _commands, _vertices, _indices;
        static byte[] _lastMemory;

        static NkDrawVertexLayoutElement* _vertexLayout;

        private delegate IntPtr NkAlloc(NkHandle handle, IntPtr old, IntPtr size);
        static NkAlloc _alloc;
        private delegate void NkFree(NkHandle handle, IntPtr ptr);
        static NkFree _free;

        static IFrameBuffered? _frameBuffered;

        static bool _forceUpdateQueued;

        static bool _initialized = false;
        static bool _forceDirty = false;

        private static bool MemCmp(void* a, void* b, int count) {
            var a1 = new ReadOnlySpan<byte>(a, count);
            var a2 = new ReadOnlySpan<byte>(b, count);
            return a1.SequenceEqual(a2);
        }

        static void FontStash(FontStashAction a = null) {
            Nk.font_atlas_init(_fontAtlas, _allocator);
            Nk.font_atlas_begin(_fontAtlas);

            a?.Invoke(new IntPtr(_fontAtlas));

            int w, h;
            var image = (IntPtr)Nk.font_atlas_bake(_fontAtlas, &w, &h, NkFontAtlasFormat.Rgba32);
            int texHandle = Dev.CreateTextureHandle(w, h, image);

            Nk.font_atlas_end(_fontAtlas, Nk.handle_id(texHandle), _nullTexture);

            if (_fontAtlas->DefaultFont != null)
                Nk.style_set_font(Ctx, &_fontAtlas->DefaultFont->Handle);
        }


        public static bool HandleInput() {
            bool hasInput = _frameBuffered == null || Dev.Events.Count > 0;

            if (hasInput) {
                Nk.input_begin(Ctx);

                while (Dev.Events.Count > 0) {
                    var e = Dev.Events.Dequeue();

                    switch (e.EvtType) {
                        case NuklearEvent.EventType.MouseButton:
                            Nk.input_button(Ctx, (NkButtons)e.MButton, e.X, e.Y, e.Down);
                            break;

                        case NuklearEvent.EventType.MouseMove:
                            Nk.input_motion(Ctx, e.X, e.Y);
                            break;

                        case NuklearEvent.EventType.Scroll:
                            Nk.input_scroll(Ctx, new NkVec2() { X = e.ScrollX, Y = e.ScrollY });
                            break;

                        case NuklearEvent.EventType.Text:
                            for (int i = 0; i < e.Text.Length; i++) {
                                if (!char.IsControl(e.Text[i]))
                                    Nk.input_unicode(Ctx, e.Text[i]);
                            }

                            break;

                        case NuklearEvent.EventType.KeyboardKey:
                            Nk.input_key(Ctx, e.Key, e.Down);
                            break;

                        case NuklearEvent.EventType.ForceUpdate:
                            _forceDirty = true;
                            break;

                        default:
                            throw new NotImplementedException();
                    }
                }

                Nk.input_end(Ctx);
            }

            return hasInput;
        }

        public static void Render(bool hadInput) {
            if (hadInput) {
                bool dirty = true;

                if (_frameBuffered != null) {
                    dirty = false;

                    void* memoryBuffer = Nk.buffer_memory(&Ctx->Memory);
                    if ((int)Ctx->Memory.Allocated == 0)
                        dirty = true;

                    if (!dirty) {
                        if (_lastMemory == null || _lastMemory.Length < (int)Ctx->Memory.Allocated) {
                            _lastMemory = new byte[(int)Ctx->Memory.Allocated];
                            dirty = true;
                        }
                    }

                    if (!dirty) {
                        fixed (byte* lastMemoryPtr = _lastMemory)
                            if (!MemCmp(lastMemoryPtr, memoryBuffer, (int)Ctx->Memory.Allocated)) {
                                dirty = true;
                                Marshal.Copy((IntPtr)memoryBuffer, _lastMemory, 0, (int)Ctx->Memory.Allocated);
                            }
                    }
                }

                if (dirty || _forceDirty) {
                    _forceDirty = false;

                    NkConvertResult r = (NkConvertResult)Nk.convert(Ctx, _commands, _vertices, _indices, _convertCfg);
                    if (r != NkConvertResult.Success)
                        throw new Exception(r.ToString());

                    NkVertex[] nkVerts = new NkVertex[(int)_vertices->Needed / sizeof(NkVertex)];
                    NkVertex* vertsPtr = (NkVertex*)_vertices->Memory.Ptr;

                    for (int i = 0; i < nkVerts.Length; i++) {
                        //NkVertex* V = &VertsPtr[i];
                        //NkVerts[i] = new NkVertex() { Position = new NkVector2f() { X = (int)V->Position.X, Y = (int)V->Position.Y }, Color = V->Color, UV = V->UV };

                        nkVerts[i] = vertsPtr[i];
                    }

                    ushort[] nkIndices = new ushort[(int)_indices->Needed / sizeof(ushort)];
                    ushort* indicesPtr = (ushort*)_indices->Memory.Ptr;
                    for (int i = 0; i < nkIndices.Length; i++)
                        nkIndices[i] = indicesPtr[i];

                    Dev.SetBuffer(nkVerts, nkIndices);
                    _frameBuffered?.BeginBuffering();

                    uint offset = 0;
                    Dev.BeginRender();

                    Nk.DrawForeach(Ctx, _commands, (cmd) => {
                        if (cmd->ElemCount == 0)
                            return;

                        Dev.Render(cmd->Userdata, cmd->Texture.id, cmd->ClipRect, offset, cmd->ElemCount);
                        offset += cmd->ElemCount;
                    });

                    Dev.EndRender();
                    _frameBuffered?.EndBuffering();
                }

                var list = &Ctx->DrawList;
                if (list != null) {
                    if (list->Buffer != null)
                        Nk.buffer_clear(list->Buffer);

                    if (list->Vertices != null)
                        Nk.buffer_clear(list->Vertices);

                    if (list->Elements != null)
                        Nk.buffer_clear(list->Elements);
                }

                Nk.clear(Ctx);
            }

            _frameBuffered?.RenderFinal();
        }

        //public  NuklearAPI(NuklearDevice Device) {
        public static void Init(NuklearDevice device) {
            if (_initialized)
                throw new InvalidOperationException("NuklearAPI.Init is called twice");

            _initialized = true;

            Dev = device;

            if (device.EnableFrameBuffered)
                _frameBuffered = device as IFrameBuffered;
            else
                _frameBuffered = null;


            // TODO: Free these later
            var a = Marshal.AllocHGlobal(Marshal.SizeOf<NkContext>());
            Ctx = (NkContext*)a;
            _allocator = (NkAllocator*)Marshal.AllocHGlobal(Marshal.SizeOf<NkAllocator>());
            _fontAtlas = (NkFontAtlas*)Marshal.AllocHGlobal(Marshal.SizeOf<NkFontAtlas>());
            _nullTexture = (NkDrawNullTexture*)Marshal.AllocHGlobal(Marshal.SizeOf<NkDrawNullTexture>());
            _convertCfg = (NkConvertConfig*)Marshal.AllocHGlobal(Marshal.SizeOf<NkConvertConfig>());
            _commands = (NkBuffer*)Marshal.AllocHGlobal(Marshal.SizeOf<NkBuffer>());
            _vertices = (NkBuffer*)Marshal.AllocHGlobal(Marshal.SizeOf<NkBuffer>());
            _indices = (NkBuffer*)Marshal.AllocHGlobal(Marshal.SizeOf<NkBuffer>());

            _vertexLayout = (NkDrawVertexLayoutElement*)Marshal.AllocHGlobal(Marshal.SizeOf<NkDrawVertexLayoutElement>()* 4);
            _vertexLayout[0] = new NkDrawVertexLayoutElement
            {
                Attribute = NkDrawVertexLayoutAttribute.Position, 
                Format = NkDrawVertexLayoutFormat.Float,
                Offset = (ulong)Marshal.OffsetOf(typeof(NkVertex), nameof(NkVertex.Position))
            };
            _vertexLayout[1] = new NkDrawVertexLayoutElement
            {
                Attribute = NkDrawVertexLayoutAttribute.Texcoord, 
                Format = NkDrawVertexLayoutFormat.Float,
                Offset = (ulong)Marshal.OffsetOf(typeof(NkVertex), nameof(NkVertex.UV))
            };
            _vertexLayout[2] = new NkDrawVertexLayoutElement
            {
                Attribute = NkDrawVertexLayoutAttribute.Color, 
                Format = NkDrawVertexLayoutFormat.Float,
                Offset = (ulong)Marshal.OffsetOf(typeof(NkVertex), nameof(NkVertex.Color))
            };
            _vertexLayout[3] = new NkDrawVertexLayoutElement {
                Attribute = NkDrawVertexLayoutAttribute.AttributeCount,
                Format = NkDrawVertexLayoutFormat.Count,
                Offset = 0
            };

            _alloc = (handle, old, size) => Marshal.AllocHGlobal(size);
            _free = (handle, old) => Marshal.FreeHGlobal(old);

            _allocator->Alloc = (delegate* unmanaged[Cdecl]<NkHandle, void*, ulong, void*>)Marshal.GetFunctionPointerForDelegate(_alloc);
            _allocator->Free = (delegate* unmanaged[Cdecl]<NkHandle, void*, void>)Marshal.GetFunctionPointerForDelegate(_free);

            Nk.init(Ctx, _allocator, null);

            Dev.Init();
            FontStash(Dev.FontStash);

            _convertCfg->ShapeAa = NkAntiAliasing.On;
            _convertCfg->LineAa = NkAntiAliasing.On;
            _convertCfg->VertexLayout = _vertexLayout;
            _convertCfg->VertexSize = (ulong)sizeof(NkVertex);
            _convertCfg->VertexAlignment = 1;
            _convertCfg->CircleSegmentCount = 22;
            _convertCfg->CurveSegmentCount = 22;
            _convertCfg->ArcSegmentCount = 22;
            _convertCfg->GlobalAlpha = 1.0f;
            _convertCfg->TexNull = *_nullTexture;

            Nk.buffer_init(_commands, _allocator, 4 * 1024);
            Nk.buffer_init(_vertices, _allocator, 4 * 1024);
            Nk.buffer_init(_indices, _allocator, 4 * 1024);
        }

        public static void Frame(Action a) {
            if (!_initialized)
                throw new InvalidOperationException("You forgot to call NuklearAPI.Init");

            if (_forceUpdateQueued) {
                _forceUpdateQueued = false;

                Dev?.ForceUpdate();
            }

            bool hasInput;
            if (hasInput = HandleInput())
                a();

            Render(hasInput);
        }

        public static void SetDeltaTime(float delta) {
            if (Ctx != null)
                Ctx->DeltaTimeSeconds = delta;
        }

        public static bool Window(string name, string title, float x, float y, float w, float h, NkPanelFlags flags, Action a) {
            bool res = true;
            
            if (Nk.begin_titled(Ctx, name, title, new NkRect(x, y, w, h), (uint)flags))
                a?.Invoke();
            else
                res = false;

            Nk.end(Ctx);
            return res;
        }

        public static bool Window(string title, float x, float y, float w, float h, NkPanelFlags flags, Action a) => Window(title, title, x, y, w, h, flags, a);

        public static bool WindowIsClosed(string name) => Nk.window_is_closed(Ctx, name);

        public static bool WindowIsHidden(string name) => Nk.window_is_hidden(Ctx, name);

        public static bool WindowIsCollapsed(string name) => Nk.window_is_collapsed(Ctx, name);

        public static bool Group(string name, string title, NkPanelFlags flags, Action a) {
            bool res = true;

            if (Nk.group_begin_titled(Ctx, name, title, (uint)flags))
                a?.Invoke();
            else
                res = false;

            Nk.group_end(Ctx);
            return res;
        }

        public static bool Group(string name, NkPanelFlags flags, Action a) => Group(name, name, flags, a);

        public static bool ButtonLabel(string label) {
            return Nk.button_label(Ctx, label);
        }

        public static bool ButtonText(string text) {
            return Nk.button_text(Ctx, text);
        }

        public static bool ButtonText(char @char) => ButtonText(@char.ToString());

        public static void LayoutRowStatic(float height, int itemWidth, int cols) {
            Nk.layout_row_static(Ctx, height, itemWidth, cols);
        }

        public static void LayoutRowDynamic(float height = 0, int cols = 1) {
            Nk.layout_row_dynamic(Ctx, height, cols);
        }

        public static void Label(string txt, NkTextAlign textAlign = (NkTextAlign)NkTextAlignment.Left) {
            Nk.label(Ctx, txt, (uint)textAlign);
        }

        public static void LabelWrap(string txt) {
            //Nk.label(Ctx, Txt, (uint)TextAlign);
            //Nk.label_wrap(Ctx, txt); TODO:
        }

        public static void LabelColored(string txt, NkColor clr, NkTextAlign textAlign = (NkTextAlign)NkTextAlignment.Left) {
            //Nk.label_colored(Ctx, txt, (uint)textAlign, clr); TODO:
        }

        public static void LabelColored(string txt, byte r, byte g, byte b, byte a, NkTextAlign textAlign = (NkTextAlign)NkTextAlignment.Left) {
            //Nk.label_colored(Ctx, Txt, (uint)TextAlign, new NkColor() { r = R, g = G, b = B, a = A });
            LabelColored(txt, new NkColor() { R = r, G = g, B = b, A = a }, textAlign);
        }

        public static void LabelColoredWrap(string txt, NkColor clr) {
            //Nk.label_colored_wrap(Ctx, txt, clr); TODO:
        }

        public static void LabelColoredWrap(string txt, byte r, byte g, byte b, byte a) {
            LabelColoredWrap(txt, new NkColor() { R = r, G = g, B = b, A = a });
        }

        public static NkRect WindowGetBounds() {
            return Nk.window_get_bounds(Ctx);
        }

        public delegate bool NkPluginFilter(ref NkTextEdit TextEdit, uint unicode);
        public static NkEditEvents? EditString(NkEditTypes editType, StringBuilder buffer, NkPluginFilter filter) {
            return null; //TODO:
            //return (NkEditEvents)Nk.edit_string_zero_terminated(Ctx, (uint)editType, buffer, buffer.MaxCapacity, filter);
        }

        public static NkEditEvents? EditString(NkEditTypes editType, StringBuilder buffer) {
            return EditString(editType, buffer, (ref NkTextEdit textBox, uint rune) => true);
        }

        public static bool IsKeyPressed(NkKeys key) {
            //Nk.input_is_key_pressed()
            return Nk.input_is_key_pressed(&Ctx->Input, key);
        }

        public static void QueueForceUpdate() {
            _forceUpdateQueued = true;
        }

        public static void WindowClose(string name) {
            Nk.window_close(Ctx, name);
        }

        public delegate void NkPluginCopy(NkHandle Handle, byte* str, int len);
        public delegate void NkPluginPaste(NkHandle Handle, ref NkTextEdit str);
        public static void SetClipboardCallback(Action<string> copyFunc, Func<string> pasteFunc) {
            // TODO: Contains alloc and forget, don't call SetClipboardCallback too many times


            NkPluginCopy nkCopyFunc = (handle, str, len) => {
                byte[] bytes = new byte[len];

                for (int i = 0; i < bytes.Length; i++)
                    bytes[i] = str[i];

                copyFunc(Encoding.UTF8.GetString(bytes));
            };

            NkPluginPaste nkPasteFunc = (NkHandle handle, ref NkTextEdit textEdit) => {
                byte[] bytes = Encoding.UTF8.GetBytes(pasteFunc());

                //TODO:
                /*fixed (byte* bytesPtr = bytes)
                fixed (NkTextEdit* textEditPtr = &textEdit)
                    Nk.textedit_paste(textEditPtr, bytesPtr, bytes.Length);*/
            };

            GCHandle.Alloc(copyFunc);
            GCHandle.Alloc(pasteFunc);
            GCHandle.Alloc(nkCopyFunc);
            GCHandle.Alloc(nkPasteFunc);

            Ctx->Clip.Copy = (delegate* unmanaged[Cdecl]<NkHandle, sbyte*, int, void>)Marshal.GetFunctionPointerForDelegate(nkCopyFunc);
            Ctx->Clip.Paste = (delegate* unmanaged[Cdecl]<NkHandle, NkTextEdit*, void>)Marshal.GetFunctionPointerForDelegate(nkPasteFunc);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NkVector2F {
        public float X, Y;

        public NkVector2F(float x, float y) {
            this.X = x;
            this.Y = y;
        }

        public override string ToString() {
            return string.Format("({0}, {1})", X, Y);
        }

        public static implicit operator Vector2(NkVector2F v) {
            return new Vector2(v.X, v.Y);
        }

        public static implicit operator NkVector2F(Vector2 v) {
            return new NkVector2F(v.X, v.Y);
        }
    }

    /*[StructLayout(LayoutKind.Sequential)]
	public struct NkColor {
		public byte R, G, B, A;

		public override string ToString() {
			return string.Format("({0}, {1}, {2}, {3})", R, G, B, A);
		}
	}*/

    [StructLayout(LayoutKind.Sequential)]
    public struct NkVertex {
        public NkVector2F Position;
        public NkVector2F UV;
        public NkColor Color;

        public override string ToString() {
            return string.Format("Position: {0}; UV: {1}; Color: {2}", Position, UV, Color);
        }
    }

    public struct NuklearEvent {
        public enum EventType {
            MouseButton,
            MouseMove,
            Scroll,
            Text,
            KeyboardKey,
            ForceUpdate
        }

        public enum MouseButton {
            Left, Middle, Right
        }

        public EventType EvtType;
        public MouseButton MButton;
        public NkKeys Key;
        public int X, Y;
        public bool Down;
        public float ScrollX, ScrollY;
        public string Text;
    }

    public interface IFrameBuffered {
        void BeginBuffering();
        void EndBuffering();
        void RenderFinal();
    }

    public unsafe abstract class NuklearDevice {
        internal Queue<NuklearEvent> Events;

        public virtual bool EnableFrameBuffered {
            get {
                return true;
            }
        }

        public abstract void SetBuffer(NkVertex[] vertexBuffer, ushort[] indexBuffer);
        public abstract void Render(NkHandle userdata, int texture, NkRect clipRect, uint offset, uint count);
        public abstract int CreateTextureHandle(int w, int h, IntPtr data);

        public NuklearDevice() {
            Events = new Queue<NuklearEvent>();
            ForceUpdate();
        }

        public virtual void Init() {
        }

        public virtual void FontStash(IntPtr atlas) {
        }

        public virtual void BeginRender() {
        }

        public virtual void EndRender() {
        }

        public void OnMouseButton(NuklearEvent.MouseButton mouseButton, int x, int y, bool down) {
            Events.Enqueue(new NuklearEvent() { EvtType = NuklearEvent.EventType.MouseButton, MButton = mouseButton, X = x, Y = y, Down = down });
        }

        public void OnMouseMove(int x, int y) {
            Events.Enqueue(new NuklearEvent() { EvtType = NuklearEvent.EventType.MouseMove, X = x, Y = y });
        }

        public void OnScroll(float scrollX, float scrollY) {
            Events.Enqueue(new NuklearEvent() { EvtType = NuklearEvent.EventType.Scroll, ScrollX = scrollX, ScrollY = scrollY });
        }

        public void OnText(string txt) {
            Events.Enqueue(new NuklearEvent() { EvtType = NuklearEvent.EventType.Text, Text = txt });
        }

        public void OnKey(NkKeys key, bool down) {
            Events.Enqueue(new NuklearEvent() { EvtType = NuklearEvent.EventType.KeyboardKey, Key = key, Down = down });
        }

        public void ForceUpdate() {
            Events.Enqueue(new NuklearEvent() { EvtType = NuklearEvent.EventType.ForceUpdate });
        }
    }

    public unsafe abstract class NuklearDeviceTex<T> : NuklearDevice {
        List<T> _textures;

        public NuklearDeviceTex() {
            _textures = new List<T>();
            _textures.Add(default(T)); // Start indices at 1
        }

        public int CreateTextureHandle(T tex) {
            _textures.Add(tex);
            return _textures.Count - 1;
        }

        public T GetTexture(int handle) {
            return _textures[handle];
        }

        public sealed override int CreateTextureHandle(int w, int h, IntPtr data) {
            T tex = CreateTexture(w, h, data);
            return CreateTextureHandle(tex);
        }

        public sealed override void Render(NkHandle userdata, int texture, NkRect clipRect, uint offset, uint count) {
            Render(userdata, GetTexture(texture), clipRect, offset, count);
        }

        public abstract T CreateTexture(int w, int h, IntPtr data);

        public abstract void Render(NkHandle userdata, T texture, NkRect clipRect, uint offset, uint count);
    }
}
