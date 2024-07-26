namespace Nuklear.NET;

public unsafe partial struct NkMemory
{
    public void* Ptr;

    [NativeTypeName("nk_size")]
    public ulong Size;
}
