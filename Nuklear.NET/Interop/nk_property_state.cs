using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkPropertyState
{
    public int Active;

    public int Prev;

    [NativeTypeName("char[64]")]
    public BufferEFixedBuffer Buffer;

    public int Length;

    public int Cursor;

    public int SelectStart;

    public int SelectEnd;

    [NativeTypeName("nk_hash")]
    public uint Name;

    [NativeTypeName("unsigned int")]
    public uint Seq;

    [NativeTypeName("unsigned int")]
    public uint Old;

    public int State;

    [InlineArray(64)]
    public partial struct BufferEFixedBuffer
    {
        public sbyte E0;
    }
}
