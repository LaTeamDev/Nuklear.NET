namespace Nuklear.NET;

public unsafe partial struct FontBakeData
{
    [NativeTypeName("struct stbtt_fontinfo")]
    public StbttFontinfo Info;

    [NativeTypeName("struct stbrp_rect *")]
    public StbrpRect* Rects;

    public StbttPackRange* Ranges;

    [NativeTypeName("nk_rune")]
    public uint RangeCount;
}
