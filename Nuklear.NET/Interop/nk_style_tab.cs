namespace Nuklear.NET;

public partial struct NkStyleTab
{
    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Background;

    [NativeTypeName("struct nk_color")]
    public NkColor BorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor Text;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton TabMaximizeButton;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton TabMinimizeButton;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton NodeMaximizeButton;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton NodeMinimizeButton;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType SymMinimize;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType SymMaximize;

    public float Border;

    public float Rounding;

    public float Indent;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Spacing;
}
