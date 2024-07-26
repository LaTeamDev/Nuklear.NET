using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkBuffer
{
    [NativeTypeName("struct nk_buffer_marker[2]")]
    public MarkerEFixedBuffer Marker;

    [NativeTypeName("struct nk_allocator")]
    public NkAllocator Pool;

    [NativeTypeName("enum nk_allocation_type")]
    public NkAllocationType Type;

    [NativeTypeName("struct nk_memory")]
    public NkMemory Memory;

    public float GrowFactor;

    [NativeTypeName("nk_size")]
    public ulong Allocated;

    [NativeTypeName("nk_size")]
    public ulong Needed;

    [NativeTypeName("nk_size")]
    public ulong Calls;

    [NativeTypeName("nk_size")]
    public ulong Size;

    [InlineArray(2)]
    public partial struct MarkerEFixedBuffer
    {
        public NkBufferMarker E0;
    }
}
