namespace Nuklear.NET;

public partial struct NkStr
{
    [NativeTypeName("struct nk_buffer")]
    public NkBuffer Buffer;

    public int Len;
}
