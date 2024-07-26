namespace Nuklear.NET;

public unsafe partial struct NkStyleProperty
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

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType SymLeft;

    [NativeTypeName("enum nk_symbol_type")]
    public NkSymbolType SymRight;

    public float Border;

    public float Rounding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    [NativeTypeName("struct nk_style_edit")]
    public NkStyleEdit Edit;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton IncButton;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton DecButton;

    public NkHandle Userdata;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawBegin;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawEnd;
}
