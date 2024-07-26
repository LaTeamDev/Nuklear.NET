namespace Nuklear.NET;

public partial struct NkStyleWindow
{
    [NativeTypeName("struct nk_style_window_header")]
    public NkStyleWindowHeader Header;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem FixedBackground;

    [NativeTypeName("struct nk_color")]
    public NkColor Background;

    [NativeTypeName("struct nk_color")]
    public NkColor BorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor PopupBorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor ComboBorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor ContextualBorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor MenuBorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor GroupBorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor TooltipBorderColor;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Scaler;

    public float Border;

    public float ComboBorder;

    public float ContextualBorder;

    public float MenuBorder;

    public float GroupBorder;

    public float TooltipBorder;

    public float PopupBorder;

    public float MinRowHeightPadding;

    public float Rounding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Spacing;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ScrollbarSize;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 MinSize;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 GroupPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 PopupPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ComboPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ContextualPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 MenuPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 TooltipPadding;
}
