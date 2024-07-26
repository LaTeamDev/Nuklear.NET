namespace Nuklear.NET;

public partial struct NkCommandScissor
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    public short X;

    public short Y;

    [NativeTypeName("unsigned short")]
    public ushort W;

    [NativeTypeName("unsigned short")]
    public ushort H;
}
