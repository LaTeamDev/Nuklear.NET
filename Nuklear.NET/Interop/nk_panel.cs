namespace Nuklear.NET;

public unsafe partial struct NkPanel
{
    [NativeTypeName("enum nk_panel_type")]
    public NkPanelType Type;

    [NativeTypeName("nk_flags")]
    public uint Flags;

    [NativeTypeName("struct nk_rect")]
    public NkRect Bounds;

    [NativeTypeName("nk_uint *")]
    public uint* OffsetX;

    [NativeTypeName("nk_uint *")]
    public uint* OffsetY;

    public float AtX;

    public float AtY;

    public float MaxX;

    public float FooterHeight;

    public float HeaderHeight;

    public float Border;

    [NativeTypeName("unsigned int")]
    public uint HasScrolling;

    [NativeTypeName("struct nk_rect")]
    public NkRect Clip;

    [NativeTypeName("struct nk_menu_state")]
    public NkMenuState Menu;

    [NativeTypeName("struct nk_row_layout")]
    public NkRowLayout Row;

    [NativeTypeName("struct nk_chart")]
    public NkChart Chart;

    [NativeTypeName("struct nk_command_buffer *")]
    public NkCommandBuffer* Buffer;

    [NativeTypeName("struct nk_panel *")]
    public NkPanel* Parent;
}
