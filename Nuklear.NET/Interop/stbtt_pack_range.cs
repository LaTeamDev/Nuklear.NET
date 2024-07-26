namespace Nuklear.NET;

public unsafe partial struct StbttPackRange
{
    public float FontSize;

    public int FirstUnicodeCodepointInRange;

    public int* ArrayOfUnicodeCodepoints;

    public int NumChars;

    public StbttPackedchar* ChardataForRange;

    [NativeTypeName("unsigned char")]
    public byte HOversample;

    [NativeTypeName("unsigned char")]
    public byte VOversample;
}
