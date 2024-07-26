namespace Nuklear.NET;

public unsafe partial struct NkPageElement
{
    [NativeTypeName("union nk_page_data")]
    public NkPageData Data;

    [NativeTypeName("struct nk_page_element *")]
    public NkPageElement* Next;

    [NativeTypeName("struct nk_page_element *")]
    public NkPageElement* Prev;
}
