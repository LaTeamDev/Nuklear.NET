namespace Nuklear.NET;

public partial struct NkCommandLine
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    [NativeTypeName("unsigned short")]
    public ushort LineThickness;

    [NativeTypeName("struct nk_vec2i")]
    public NkVec2I Begin;

    [NativeTypeName("struct nk_vec2i")]
    public NkVec2I End;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;
}
