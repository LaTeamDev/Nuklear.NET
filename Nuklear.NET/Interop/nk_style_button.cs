namespace Nuklear.NET;

public unsafe partial struct NkStyleButton
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
    public NkColor TextBackground;

    [NativeTypeName("struct nk_color")]
    public NkColor TextNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor TextHover;

    [NativeTypeName("struct nk_color")]
    public NkColor TextActive;

    [NativeTypeName("nk_flags")]
    public uint TextAlignment;

    public float Border;

    public float Rounding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ImagePadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 TouchPadding;

    public NkHandle Userdata;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawBegin;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawEnd;
}
