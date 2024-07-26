namespace Nuklear.NET;

public unsafe partial struct StbttBuf
{
    [NativeTypeName("unsigned char *")]
    public byte* Data;

    public int Cursor;

    public int Size;
}
