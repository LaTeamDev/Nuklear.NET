namespace Nuklear.NET;

public unsafe partial struct NkUserFont
{
    public NkHandle Userdata;

    public float Height;

    [NativeTypeName("nk_text_width_f")]
    public delegate* unmanaged[Cdecl]<NkHandle, float, sbyte*, int, float> Width;

    [NativeTypeName("nk_query_font_glyph_f")]
    public delegate* unmanaged[Cdecl]<NkHandle, float, NkUserFontGlyph*, uint, uint, void> Query;

    public NkHandle Texture;
}
