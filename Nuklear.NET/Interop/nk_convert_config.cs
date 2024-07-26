namespace Nuklear.NET;

public unsafe partial struct NkConvertConfig
{
    public float GlobalAlpha;

    [NativeTypeName("enum nk_anti_aliasing")]
    public NkAntiAliasing LineAa;

    [NativeTypeName("enum nk_anti_aliasing")]
    public NkAntiAliasing ShapeAa;

    [NativeTypeName("unsigned int")]
    public uint CircleSegmentCount;

    [NativeTypeName("unsigned int")]
    public uint ArcSegmentCount;

    [NativeTypeName("unsigned int")]
    public uint CurveSegmentCount;

    [NativeTypeName("struct nk_draw_null_texture")]
    public NkDrawNullTexture TexNull;

    [NativeTypeName("const struct nk_draw_vertex_layout_element *")]
    public NkDrawVertexLayoutElement* VertexLayout;

    [NativeTypeName("nk_size")]
    public ulong VertexSize;

    [NativeTypeName("nk_size")]
    public ulong VertexAlignment;
}
