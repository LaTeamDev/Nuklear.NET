namespace Nuklear.NET;

public unsafe partial struct NkStyleSlider
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
    public NkColor BarNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor BarHover;

    [NativeTypeName("struct nk_color")]
    public NkColor BarActive;

    [NativeTypeName("struct nk_color")]
    public NkColor BarFilled;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem CursorNormal;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem CursorHover;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem CursorActive;

    public float Border;

    public float Rounding;

    public float BarHeight;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Spacing;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 CursorSize;

    public int ShowButtons;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton IncButton;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton DecButton;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType IncSymbol;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType DecSymbol;

    public NkHandle Userdata;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawBegin;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawEnd;
}
