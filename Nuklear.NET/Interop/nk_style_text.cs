namespace Nuklear.NET;

public partial struct NkStyleText
{
    [NativeTypeName("struct nk_color")]
    public NkColor Color;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;
}
