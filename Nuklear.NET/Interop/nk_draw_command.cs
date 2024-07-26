namespace Nuklear.NET;

public partial struct NkDrawCommand
{
    [NativeTypeName("unsigned int")]
    public uint ElemCount;

    [NativeTypeName("struct nk_rect")]
    public NkRect ClipRect;

    public NkHandle Texture;

    public NkHandle Userdata;
}
