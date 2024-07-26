namespace Nuklear.NET;

public enum NkPanelFlags
{
    Border = (1 << (0)),
    Movable = (1 << (1)),
    Scalable = (1 << (2)),
    Closable = (1 << (3)),
    Minimizable = (1 << (4)),
    NoScrollbar = (1 << (5)),
    Title = (1 << (6)),
    ScrollAutoHide = (1 << (7)),
    Background = (1 << (8)),
    ScaleLeft = (1 << (9)),
    NoInput = (1 << (10)),
}
