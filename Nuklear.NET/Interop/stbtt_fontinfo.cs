namespace Nuklear.NET;

public unsafe partial struct StbttFontinfo
{
    public void* Userdata;

    [NativeTypeName("unsigned char *")]
    public byte* Data;

    public int Fontstart;

    public int NumGlyphs;

    public int Loca;

    public int Head;

    public int Glyf;

    public int Hhea;

    public int Hmtx;

    public int Kern;

    public int Gpos;

    public int Svg;

    public int IndexMap;

    public int IndexToLocFormat;

    public StbttBuf Cff;

    public StbttBuf Charstrings;

    public StbttBuf Gsubrs;

    public StbttBuf Subrs;

    public StbttBuf Fontdicts;

    public StbttBuf Fdselect;
}
