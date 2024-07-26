namespace Nuklear.NET;

public unsafe partial struct NkClipboard
{
    public NkHandle Userdata;

    [NativeTypeName("nk_plugin_paste")]
    public delegate* unmanaged[Cdecl]<NkHandle, NkTextEdit*, void> Paste;

    [NativeTypeName("nk_plugin_copy")]
    public delegate* unmanaged[Cdecl]<NkHandle, sbyte*, int, void> Copy;
}
