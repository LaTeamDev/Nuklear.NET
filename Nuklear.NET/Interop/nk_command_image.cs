namespace Nuklear.NET;

public partial struct NkCommandImage
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    public short X;

    public short Y;

    [NativeTypeName("unsigned short")]
    public ushort W;

    [NativeTypeName("unsigned short")]
    public ushort H;

    [NativeTypeName("struct nk_image")]
    public NkImage Img;

    [NativeTypeName("struct nk_color")]
    public NkColor Col;
}
