namespace Nuklear.NET;

public partial struct NkCursor
{
    [NativeTypeName("struct nk_image")]
    public NkImage Img;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Size;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Offset;
}
