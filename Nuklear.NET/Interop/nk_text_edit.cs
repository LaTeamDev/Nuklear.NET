namespace Nuklear.NET;

public unsafe partial struct NkTextEdit
{
    [NativeTypeName("struct nk_clipboard")]
    public NkClipboard Clip;

    [NativeTypeName("struct nk_str")]
    public NkStr String;

    [NativeTypeName("nk_plugin_filter")]
    public delegate* unmanaged[Cdecl]<NkTextEdit*, uint, bool> Filter;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Scrollbar;

    public int Cursor;

    public int SelectStart;

    public int SelectEnd;

    [NativeTypeName("unsigned char")]
    public byte Mode;

    [NativeTypeName("unsigned char")]
    public byte CursorAtEndOfLine;

    [NativeTypeName("unsigned char")]
    public byte Initialized;

    [NativeTypeName("unsigned char")]
    public byte HasPreferredX;

    [NativeTypeName("unsigned char")]
    public byte SingleLine;

    [NativeTypeName("unsigned char")]
    public byte Active;

    [NativeTypeName("unsigned char")]
    public byte Padding1;

    public float PreferredX;

    [NativeTypeName("struct nk_text_undo_state")]
    public NkTextUndoState Undo;
}
