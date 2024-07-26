namespace Nuklear.NET;

public partial struct NkCommand
{
    [NativeTypeName("enum nk_command_type")]
    public NkCommandType Type;

    [NativeTypeName("nk_size")]
    public ulong Next;

    public NkHandle Userdata;
}
