namespace Nuklear.NET;

public partial struct NkNineSlice
{
    [NativeTypeName("struct nk_image")]
    public NkImage Img;

    [NativeTypeName("nk_ushort")]
    public ushort L;

    [NativeTypeName("nk_ushort")]
    public ushort T;

    [NativeTypeName("nk_ushort")]
    public ushort R;

    [NativeTypeName("nk_ushort")]
    public ushort B;
}
