namespace Nuklear.NET;

public partial struct NkPopupBuffer
{
    [NativeTypeName("nk_size")]
    public ulong Begin;

    [NativeTypeName("nk_size")]
    public ulong Parent;

    [NativeTypeName("nk_size")]
    public ulong Last;

    [NativeTypeName("nk_size")]
    public ulong End;

    [NativeTypeName("nk_bool")]
    public bool Active;
}
