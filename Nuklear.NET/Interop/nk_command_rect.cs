namespace Nuklear.NET;

public partial struct NkCommandRect
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    [NativeTypeName("unsigned short")]
    public ushort Rounding;

    [NativeTypeName("unsigned short")]
    public ushort LineThickness;

    public short X;

    public short Y;

    [NativeTypeName("unsigned short")]
    public ushort W;

    [NativeTypeName("unsigned short")]
    public ushort H;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;
}
