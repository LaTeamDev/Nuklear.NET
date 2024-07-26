using System.Runtime.InteropServices;

namespace Nuklear.NET;

[StructLayout(LayoutKind.Explicit)]
public partial struct Property
{
    [FieldOffset(0)]
    public int i;

    [FieldOffset(0)]
    public float f;

    [FieldOffset(0)]
    public double d;
}
