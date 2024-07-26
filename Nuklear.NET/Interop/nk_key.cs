namespace Nuklear.NET;

public partial struct NkKey
{
    [NativeTypeName("nk_bool")]
    public bool Down;

    [NativeTypeName("unsigned int")]
    public uint Clicked;
}
