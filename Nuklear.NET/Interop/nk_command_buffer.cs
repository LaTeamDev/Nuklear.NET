namespace Nuklear.NET;

public unsafe partial struct NkCommandBuffer
{
    [NativeTypeName("struct nk_buffer *")]
    public NkBuffer* Base;

    [NativeTypeName("struct nk_rect")]
    public NkRect Clip;

    public int UseClipping;

    public NkHandle Userdata;

    [NativeTypeName("nk_size")]
    public ulong Begin;

    [NativeTypeName("nk_size")]
    public ulong End;

    [NativeTypeName("nk_size")]
    public ulong Last;
}
