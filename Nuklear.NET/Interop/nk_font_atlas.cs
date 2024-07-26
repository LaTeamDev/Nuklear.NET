using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public unsafe partial struct NkFontAtlas
{
    public void* Pixel;

    public int TexWidth;

    public int TexHeight;

    [NativeTypeName("struct nk_allocator")]
    public NkAllocator Permanent;

    [NativeTypeName("struct nk_allocator")]
    public NkAllocator Temporary;

    [NativeTypeName("struct nk_recti")]
    public NkRecti Custom;

    [NativeTypeName("struct nk_cursor[7]")]
    public CursorsEFixedBuffer Cursors;

    public int GlyphCount;

    [NativeTypeName("struct nk_font_glyph *")]
    public NkFontGlyph* Glyphs;

    [NativeTypeName("struct nk_font *")]
    public NkFont* DefaultFont;

    [NativeTypeName("struct nk_font *")]
    public NkFont* Fonts;

    [NativeTypeName("struct nk_font_config *")]
    public NkFontConfig* Config;

    public int FontNum;

    [InlineArray(7)]
    public partial struct CursorsEFixedBuffer
    {
        public NkCursor E0;
    }
}
