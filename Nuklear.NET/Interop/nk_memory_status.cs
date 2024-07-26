namespace Nuklear.NET;

public unsafe partial struct NkMemoryStatus
{
    public void* Memory;

    [NativeTypeName("unsigned int")]
    public uint Type;

    [NativeTypeName("nk_size")]
    public ulong Size;

    [NativeTypeName("nk_size")]
    public ulong Allocated;

    [NativeTypeName("nk_size")]
    public ulong Needed;

    [NativeTypeName("nk_size")]
    public ulong Calls;
}
