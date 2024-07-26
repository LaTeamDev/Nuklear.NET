namespace Nuklear.NET;

public partial struct NkDrawVertexLayoutElement
{
    [NativeTypeName("enum nk_draw_vertex_layout_attribute")]
    public NkDrawVertexLayoutAttribute Attribute;

    [NativeTypeName("enum nk_draw_vertex_layout_format")]
    public NkDrawVertexLayoutFormat Format;

    [NativeTypeName("nk_size")]
    public ulong Offset;
}
