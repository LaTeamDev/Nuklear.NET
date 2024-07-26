namespace Nuklear.NET;

public enum NkPanelType
{
    None = 0,
    Window = (1 << (0)),
    Group = (1 << (1)),
    Popup = (1 << (2)),
    Contextual = (1 << (4)),
    Combo = (1 << (5)),
    Menu = (1 << (6)),
    Tooltip = (1 << (7)),
}
