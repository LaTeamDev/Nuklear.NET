using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkCommandCurve
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    [NativeTypeName("unsigned short")]
    public ushort LineThickness;

    [NativeTypeName("struct nk_vec2i")]
    public NkVec2I Begin;

    [NativeTypeName("struct nk_vec2i")]
    public NkVec2I End;

    [NativeTypeName("struct nk_vec2i[2]")]
    public CtrlEFixedBuffer Ctrl;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;

    [InlineArray(2)]
    public partial struct CtrlEFixedBuffer
    {
        public NkVec2I E0;
    }
}
