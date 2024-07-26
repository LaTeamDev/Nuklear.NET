namespace Nuklear.NET;

public unsafe partial struct NkPopupState
{
    [NativeTypeName("struct nk_window *")]
    public NkWindow* Win;

    [NativeTypeName("enum nk_panel_type")]
    public NkPanelType Type;

    [NativeTypeName("struct nk_popup_buffer")]
    public NkPopupBuffer Buf;

    [NativeTypeName("nk_hash")]
    public uint Name;

    [NativeTypeName("nk_bool")]
    public bool Active;

    [NativeTypeName("unsigned int")]
    public uint ComboCount;

    [NativeTypeName("unsigned int")]
    public uint ConCount;

    [NativeTypeName("unsigned int")]
    public uint ConOld;

    [NativeTypeName("unsigned int")]
    public uint ActiveCon;

    [NativeTypeName("struct nk_rect")]
    public NkRect Header;
}
