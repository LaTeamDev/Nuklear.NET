using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public unsafe partial struct NkWindow
{
    [NativeTypeName("unsigned int")]
    public uint Seq;

    [NativeTypeName("nk_hash")]
    public uint Name;

    [NativeTypeName("char[64]")]
    public NameStringEFixedBuffer NameString;

    [NativeTypeName("nk_flags")]
    public uint Flags;

    [NativeTypeName("struct nk_rect")]
    public NkRect Bounds;

    [NativeTypeName("struct nk_scroll")]
    public NkScroll Scrollbar;

    [NativeTypeName("struct nk_command_buffer")]
    public NkCommandBuffer Buffer;

    [NativeTypeName("struct nk_panel *")]
    public NkPanel* Layout;

    public float ScrollbarHidingTimer;

    [NativeTypeName("struct nk_property_state")]
    public NkPropertyState Property;

    [NativeTypeName("struct nk_popup_state")]
    public NkPopupState Popup;

    [NativeTypeName("struct nk_edit_state")]
    public NkEditState Edit;

    [NativeTypeName("unsigned int")]
    public uint Scrolled;

    [NativeTypeName("struct nk_table *")]
    public NkTable* Tables;

    [NativeTypeName("unsigned int")]
    public uint TableCount;

    [NativeTypeName("struct nk_window *")]
    public NkWindow* Next;

    [NativeTypeName("struct nk_window *")]
    public NkWindow* Prev;

    [NativeTypeName("struct nk_window *")]
    public NkWindow* Parent;

    [InlineArray(64)]
    public partial struct NameStringEFixedBuffer
    {
        public sbyte E0;
    }
}
