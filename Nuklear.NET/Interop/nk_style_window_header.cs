namespace Nuklear.NET;

public partial struct NkStyleWindowHeader
{
    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Normal;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Hover;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Active;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton CloseButton;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton MinimizeButton;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType CloseSymbol;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType MinimizeSymbol;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType MaximizeSymbol;

    [NativeTypeName("struct nk_color")]
    public NkColor LabelNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor LabelHover;

    [NativeTypeName("struct nk_color")]
    public NkColor LabelActive;

    [NativeTypeName("enum nk_style_header_align")]
    public NkStyleHeaderAlign Align;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 LabelPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Spacing;
}
