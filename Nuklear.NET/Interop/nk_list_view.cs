namespace Nuklear.NET;

public unsafe partial struct NkListView
{
    public int Begin;

    public int End;

    public int Count;

    public int TotalHeight;

    [NativeTypeName("struct nk_context *")]
    public NkContext* Ctx;

    [NativeTypeName("nk_uint *")]
    public uint* ScrollPointer;

    [NativeTypeName("nk_uint")]
    public uint ScrollValue;
}
