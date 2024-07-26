namespace Nuklear.NET;

public partial struct NkStyleEdit
{
    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Normal;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Hover;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Active;

    [NativeTypeName("struct nk_color")]
    public NkColor BorderColor;

    [NativeTypeName("struct nk_style_scrollbar")]
    public NkStyleScrollbar Scrollbar;

    [NativeTypeName("struct nk_color")]
    public NkColor CursorNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor CursorHover;

    [NativeTypeName("struct nk_color")]
    public NkColor CursorTextNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor CursorTextHover;

    [NativeTypeName("struct nk_color")]
    public NkColor TextNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor TextHover;

    [NativeTypeName("struct nk_color")]
    public NkColor TextActive;

    [NativeTypeName("struct nk_color")]
    public NkColor SelectedNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor SelectedHover;

    [NativeTypeName("struct nk_color")]
    public NkColor SelectedTextNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor SelectedTextHover;

    public float Border;

    public float Rounding;

    public float CursorSize;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ScrollbarSize;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    public float RowPadding;
}
