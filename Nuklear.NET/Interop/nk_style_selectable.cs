namespace Nuklear.NET;

public unsafe partial struct NkStyleSelectable
{
    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Normal;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Hover;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Pressed;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem NormalActive;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem HoverActive;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem PressedActive;

    [NativeTypeName("struct nk_color")]
    public NkColor TextNormal;

    [NativeTypeName("struct nk_color")]
    public NkColor TextHover;

    [NativeTypeName("struct nk_color")]
    public NkColor TextPressed;

    [NativeTypeName("struct nk_color")]
    public NkColor TextNormalActive;

    [NativeTypeName("struct nk_color")]
    public NkColor TextHoverActive;

    [NativeTypeName("struct nk_color")]
    public NkColor TextPressedActive;

    [NativeTypeName("struct nk_color")]
    public NkColor TextBackground;

    [NativeTypeName("nk_flags")]
    public uint TextAlignment;

    public float Rounding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 TouchPadding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ImagePadding;

    public NkHandle Userdata;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawBegin;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawEnd;
}
