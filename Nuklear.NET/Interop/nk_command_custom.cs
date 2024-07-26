namespace Nuklear.NET;

public unsafe partial struct NkCommandCustom
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    public short X;

    public short Y;

    [NativeTypeName("unsigned short")]
    public ushort W;

    [NativeTypeName("unsigned short")]
    public ushort H;

    public NkHandle CallbackData;

    [NativeTypeName("nk_command_custom_callback")]
    public delegate* unmanaged[Cdecl]<void*, short, short, ushort, ushort, NkHandle, void> Callback;
}
