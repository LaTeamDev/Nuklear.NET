namespace Nuklear.NET;

public enum NkEditFlags
{
    Default = 0,
    ReadOnly = (1 << (0)),
    AutoSelect = (1 << (1)),
    SigEnter = (1 << (2)),
    AllowTab = (1 << (3)),
    NoCursor = (1 << (4)),
    Selectable = (1 << (5)),
    Clipboard = (1 << (6)),
    CtrlEnterNewline = (1 << (7)),
    NoHorizontalScroll = (1 << (8)),
    AlwaysInsertMode = (1 << (9)),
    Multiline = (1 << (10)),
    GotoEndOnActivate = (1 << (11)),
}
