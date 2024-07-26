namespace Nuklear.NET;

public partial struct NkCommandRectMultiColor
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    public short X;

    public short Y;

    [NativeTypeName("unsigned short")]
    public ushort W;

    [NativeTypeName("unsigned short")]
    public ushort H;

    [NativeTypeName("struct nk_color")]
    public NkColor Left;

    [NativeTypeName("struct nk_color")]
    public NkColor Top;

    [NativeTypeName("struct nk_color")]
    public NkColor Bottom;

    [NativeTypeName("struct nk_color")]
    public NkColor Right;
}
