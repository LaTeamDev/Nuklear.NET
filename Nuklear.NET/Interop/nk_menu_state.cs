namespace Nuklear.NET;

public partial struct NkMenuState
{
    public float X;

    public float Y;

    public float W;

    public float H;

    [NativeTypeName("struct nk_scroll")]
    public NkScroll Offset;
}
