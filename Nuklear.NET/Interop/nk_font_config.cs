using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public unsafe partial struct NkFontConfig
{
    [NativeTypeName("struct nk_font_config *")]
    public NkFontConfig* Next;

    public void* TtfBlob;

    [NativeTypeName("nk_size")]
    public ulong TtfSize;

    [NativeTypeName("unsigned char")]
    public byte TtfDataOwnedByAtlas;

    [NativeTypeName("unsigned char")]
    public byte MergeMode;

    [NativeTypeName("unsigned char")]
    public byte PixelSnap;

    [NativeTypeName("unsigned char")]
    public byte OversampleV;

    [NativeTypeName("unsigned char")]
    public byte OversampleH;

    [NativeTypeName("unsigned char[3]")]
    public PaddingEFixedBuffer Padding;

    public float Size;

    [NativeTypeName("enum nk_font_coord_type")]
    public NkFontCoordType CoordType;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Spacing;

    [NativeTypeName("const nk_rune *")]
    public uint* Range;

    [NativeTypeName("struct nk_baked_font *")]
    public NkBakedFont* Font;

    [NativeTypeName("nk_rune")]
    public uint FallbackGlyph;

    [NativeTypeName("struct nk_font_config *")]
    public NkFontConfig* N;

    [NativeTypeName("struct nk_font_config *")]
    public NkFontConfig* P;

    [InlineArray(3)]
    public partial struct PaddingEFixedBuffer
    {
        public byte E0;
    }
}
