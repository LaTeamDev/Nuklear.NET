namespace Nuklear.NET;

public unsafe partial struct StbttHheap
{
    [NativeTypeName("struct stbtt__hheap_chunk *")]
    public StbttHheapChunk* Head;

    public void* FirstFree;

    public int NumRemainingInHeadChunk;
}
