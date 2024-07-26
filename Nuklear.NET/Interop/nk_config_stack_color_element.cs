namespace Nuklear.NET;

public unsafe partial struct NkConfigStackColorElement
{
    [NativeTypeName("struct nk_color *")]
    public NkColor* Address;

    [NativeTypeName("struct nk_color")]
    public NkColor OldValue;
}
