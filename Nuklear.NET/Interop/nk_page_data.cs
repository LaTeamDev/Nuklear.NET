using System.Runtime.InteropServices;

namespace Nuklear.NET;

[StructLayout(LayoutKind.Explicit)]
public partial struct NkPageData
{
    [FieldOffset(0)]
    [NativeTypeName("struct nk_table")]
    public NkTable tbl;

    [FieldOffset(0)]
    [NativeTypeName("struct nk_panel")]
    public NkPanel pan;

    [FieldOffset(0)]
    [NativeTypeName("struct nk_window")]
    public NkWindow win;
}
