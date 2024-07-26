using System.Runtime.InteropServices;

namespace Nuklear.NET;

[StructLayout(LayoutKind.Explicit)]
public partial struct NkStyleItemData
{
    [FieldOffset(0)]
    [NativeTypeName("struct nk_color")]
    public NkColor color;

    [FieldOffset(0)]
    [NativeTypeName("struct nk_image")]
    public NkImage image;

    [FieldOffset(0)]
    [NativeTypeName("struct nk_nine_slice")]
    public NkNineSlice slice;
}
