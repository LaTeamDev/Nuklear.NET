namespace Nuklear.NET;

public partial struct NkBufferMarker
{
    [NativeTypeName("nk_bool")]
    public bool Active;

    [NativeTypeName("nk_size")]
    public ulong Offset;
}
