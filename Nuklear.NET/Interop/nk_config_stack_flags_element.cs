namespace Nuklear.NET;

public unsafe partial struct NkConfigStackFlagsElement
{
    [NativeTypeName("nk_flags *")]
    public uint* Address;

    [NativeTypeName("nk_flags")]
    public uint OldValue;
}
