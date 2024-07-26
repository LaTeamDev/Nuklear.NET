namespace Nuklear.NET;

public unsafe partial struct NkStyleProgress
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

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem CursorActive;

    [NativeTypeName("struct nk_color")]
    public NkColor CursorBorderColor;

    public float Rounding;

    public float Border;

    public float CursorBorder;

    public float CursorRounding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;

    public NkHandle Userdata;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawBegin;

    [NativeTypeName("void (*)(struct nk_command_buffer *, nk_handle)")]
    public delegate* unmanaged[Cdecl]<NkCommandBuffer*, NkHandle, void> DrawEnd;
}
