namespace Nuklear.NET;

public unsafe partial struct StbttBitmap
{
    public int W;

    public int H;

    public int Stride;

    [NativeTypeName("unsigned char *")]
    public byte* Pixels;
}
