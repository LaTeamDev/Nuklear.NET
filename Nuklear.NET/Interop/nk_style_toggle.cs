namespace Nuklear.NET;

public unsafe partial struct NkStyleToggle
{
    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Normal;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Hover;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Active;

    [NativeTypeName("struct nk_color")]
    public NkColor BorderColor;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem CursorNormal;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem CursorHover;

    [NativeTypeName("struct nk_color")]
    public NkColor TextNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor TextHover;

    [NativeTypeName("struct nk_color")]
    public NkColor TextActive;

    [NativeTypeName("struct nk_color")]
    public NkColor TextBackground;

    [NativeTypeName("nk_flags")]
    public uint TextAlignment;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 TouchPadding;

    public float Spacing;

    public float Border;

    public NkHandle Userdata;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawBegin;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawEnd;
}
