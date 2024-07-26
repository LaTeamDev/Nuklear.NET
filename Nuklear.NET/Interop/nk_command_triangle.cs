namespace Nuklear.NET;

public partial struct NkCommandTriangle
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    [NativeTypeName("unsigned short")]
    public ushort LineThickness;

    [NativeTypeName("struct nk_vec2i")]
    public NkVec2I A;

    [NativeTypeName("struct nk_vec2i")]
    public NkVec2I B;

    [NativeTypeName("struct nk_vec2i")]
    public NkVec2I C;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;
}
