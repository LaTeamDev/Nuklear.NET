namespace Nuklear.NET;

public partial struct NkFontGlyph
{
    [NativeTypeName("nk_rune")]
    public uint Codepoint;

    public float Xadvance;

    public float X0;

    public float Y0;

    public float X1;

    public float Y1;

    public float W;

    public float H;

    public float U0;

    public float V0;

    public float U1;

    public float V1;
}
