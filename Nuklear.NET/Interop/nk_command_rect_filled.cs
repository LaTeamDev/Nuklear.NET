namespace Nuklear.NET;

public partial struct NkCommandRectFilled
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    [NativeTypeName("unsigned short")]
    public ushort Rounding;

    public short X;

    public short Y;

    [NativeTypeName("unsigned short")]
    public ushort W;

    [NativeTypeName("unsigned short")]
    public ushort H;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;
}
