namespace Nuklear.NET;

public enum NkWidgetStates
{
    Modified = (1 << (1)),
    Inactive = (1 << (2)),
    Entered = (1 << (3)),
    Hover = (1 << (4)),
    Actived = (1 << (5)),
    Left = (1 << (6)),
    Hovered = Hover | Modified,
    Active = Actived | Modified,
}
