using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkImage
{
    public NkHandle Handle;

    [NativeTypeName("nk_ushort")]
    public ushort W;

    [NativeTypeName("nk_ushort")]
    public ushort H;

    [NativeTypeName("nk_ushort[4]")]
    public RegionEFixedBuffer Region;

    [InlineArray(4)]
    public partial struct RegionEFixedBuffer
    {
        public ushort E0;
    }
}
