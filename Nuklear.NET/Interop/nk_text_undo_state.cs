using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkTextUndoState
{
    [NativeTypeName("struct nk_text_undo_record[99]")]
    public UndoRecEFixedBuffer UndoRec;

    [NativeTypeName("nk_rune[999]")]
    public UndoCharEFixedBuffer UndoChar;

    public short UndoPoint;

    public short RedoPoint;

    public short UndoCharPoint;

    public short RedoCharPoint;

    [InlineArray(99)]
    public partial struct UndoRecEFixedBuffer
    {
        public NkTextUndoRecord E0;
    }

    [InlineArray(999)]
    public partial struct UndoCharEFixedBuffer
    {
        public uint E0;
    }
}
