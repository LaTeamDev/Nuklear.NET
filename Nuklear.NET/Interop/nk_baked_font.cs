namespace Nuklear.NET;

public unsafe partial struct NkBakedFont
{
    public float Height;

    public float Ascent;

    public float Descent;

    [NativeTypeName("nk_rune")]
    public uint GlyphOffset;

    [NativeTypeName("nk_rune")]
    public uint GlyphCount;

    [NativeTypeName("const nk_rune *")]
    public uint* Ranges;
}
