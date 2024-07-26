namespace Nuklear.NET;

public unsafe partial struct NkAllocator
{
    public NkHandle Userdata;

    [NativeTypeName("nk_plugin_alloc")]
    public delegate* unmanaged[Cdecl]<NkHandle, void*, ulong, void*> Alloc;

    [NativeTypeName("nk_plugin_free")]
    public delegate* unmanaged[Cdecl]<NkHandle, void*, void> Free;
}
