using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkCommandArc
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    public short Cx;

    public short Cy;

    [NativeTypeName("unsigned short")]
    public ushort R;

    [NativeTypeName("unsigned short")]
    public ushort LineThickness;

    [NativeTypeName("float[2]")]
    public AEFixedBuffer A;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;

    [InlineArray(2)]
    public partial struct AEFixedBuffer
    {
        public float E0;
    }
}
