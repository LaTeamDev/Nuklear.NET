namespace Nuklear.NET;

public partial struct StbttVertex
{
    public short X;

    public short Y;

    public short Cx;

    public short Cy;

    public short Cx1;

    public short Cy1;

    [NativeTypeName("unsigned char")]
    public byte Type;

    [NativeTypeName("unsigned char")]
    public byte Padding;
}
