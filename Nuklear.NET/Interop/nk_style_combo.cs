namespace Nuklear.NET;

public partial struct NkStyleCombo
{
    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Normal;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Hover;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Active;

    [NativeTypeName("struct nk_color")]
    public NkColor BorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor LabelNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor LabelHover;

    [NativeTypeName("struct nk_color")]
    public NkColor LabelActive;

    [NativeTypeName("struct nk_color")]
    public NkColor SymbolNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor SymbolHover;

    [NativeTypeName("struct nk_color")]
    public NkColor SymbolActive;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton Button;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType SymNormal;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType SymHover;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType SymActive;

    public float Border;

    public float Rounding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ContentPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ButtonPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Spacing;
}
