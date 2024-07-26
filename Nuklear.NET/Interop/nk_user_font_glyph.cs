using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkUserFontGlyph
{
    [NativeTypeName("struct nk_vec2[2]")]
    public UvEFixedBuffer Uv;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Offset;

    public float Width;

    public float Height;

    public float Xadvance;

    [InlineArray(2)]
    public partial struct UvEFixedBuffer
    {
        public NkVec2 E0;
    }
}
