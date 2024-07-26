namespace Nuklear.NET;

public unsafe partial struct StbttPackContext
{
    public void* UserAllocatorContext;

    public void* PackInfo;

    public int Width;

    public int Height;

    public int StrideInBytes;

    public int Padding;

    public int SkipMissing;

    [NativeTypeName("unsigned int")]
    public uint HOversample;

    [NativeTypeName("unsigned int")]
    public uint VOversample;

    [NativeTypeName("unsigned char *")]
    public byte* Pixels;

    public void* Nodes;
}
