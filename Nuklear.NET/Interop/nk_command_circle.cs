namespace Nuklear.NET;

public partial struct NkCommandCircle
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    public short X;

    public short Y;

    [NativeTypeName("unsigned short")]
    public ushort LineThickness;

    [NativeTypeName("unsigned short")]
    public ushort W;

    [NativeTypeName("unsigned short")]
    public ushort H;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;
}
