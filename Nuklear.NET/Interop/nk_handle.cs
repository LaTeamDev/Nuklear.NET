using System.Runtime.InteropServices;

namespace Nuklear.NET;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct NkHandle
{
    [FieldOffset(0)]
    public void* ptr;

    [FieldOffset(0)]
    public int id;
}
