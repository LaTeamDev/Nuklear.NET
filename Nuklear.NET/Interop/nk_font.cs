namespace Nuklear.NET;

public unsafe partial struct NkFont
{
    [NativeTypeName("struct nk_font *")]
    public NkFont* Next;

    [NativeTypeName("struct nk_user_font")]
    public NkUserFont Handle;

    [NativeTypeName("struct nk_baked_font")]
    public NkBakedFont Info;

    public float Scale;

    [NativeTypeName("struct nk_font_glyph *")]
    public NkFontGlyph* Glyphs;

    [NativeTypeName("const struct nk_font_glyph *")]
    public NkFontGlyph* Fallback;

    [NativeTypeName("nk_rune")]
    public uint FallbackCodepoint;

    public NkHandle Texture;

    [NativeTypeName("struct nk_font_config *")]
    public NkFontConfig* Config;
}
