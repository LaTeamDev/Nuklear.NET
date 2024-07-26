namespace Nuklear.NET;

public unsafe partial struct NkPool
{
    [NativeTypeName("struct nk_allocator")]
    public NkAllocator Alloc;

    [NativeTypeName("enum nk_allocation_type")]
    public NkAllocationType Type;

    [NativeTypeName("unsigned int")]
    public uint PageCount;

    [NativeTypeName("struct nk_page *")]
    public NkPage* Pages;

    [NativeTypeName("struct nk_page_element *")]
    public NkPageElement* Freelist;

    [NativeTypeName("unsigned int")]
    public uint Capacity;

    [NativeTypeName("nk_size")]
    public ulong Size;

    [NativeTypeName("nk_size")]
    public ulong Cap;
}
