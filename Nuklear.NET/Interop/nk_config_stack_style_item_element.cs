namespace Nuklear.NET;

public unsafe partial struct NkConfigStackStyleItemElement
{
    [NativeTypeName("struct nk_style_item *")]
    public NkStyleItem* Address;

    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem OldValue;
}
