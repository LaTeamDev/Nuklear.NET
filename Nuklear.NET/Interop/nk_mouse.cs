using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkMouse
{
    [NativeTypeName("struct nk_mouse_button[4]")]
    public ButtonsEFixedBuffer Buttons;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Pos;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 DownPos;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Prev;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Delta;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ScrollDelta;

    [NativeTypeName("unsigned char")]
    public byte Grab;

    [NativeTypeName("unsigned char")]
    public byte Grabbed;

    [NativeTypeName("unsigned char")]
    public byte Ungrab;

    [InlineArray(4)]
    public partial struct ButtonsEFixedBuffer
    {
        public NkMouseButton E0;
    }
}
