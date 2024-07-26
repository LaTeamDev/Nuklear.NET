namespace Nuklear.NET;

public partial struct NkMouseButton
{
    [NativeTypeName("nk_bool")]
    public bool Down;

    [NativeTypeName("unsigned int")]
    public uint Clicked;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 ClickedPos;
}
