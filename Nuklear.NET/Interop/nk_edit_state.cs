namespace Nuklear.NET;

public partial struct NkEditState
{
    [NativeTypeName("nk_hash")]
    public uint Name;

    [NativeTypeName("unsigned int")]
    public uint Seq;

    [NativeTypeName("unsigned int")]
    public uint Old;

    public int Active;

    public int Prev;

    public int Cursor;

    public int SelStart;

    public int SelEnd;

    [NativeTypeName("struct nk_scroll")]
    public NkScroll Scrollbar;

    [NativeTypeName("unsigned char")]
    public byte Mode;

    [NativeTypeName("unsigned char")]
    public byte SingleLine;
}
