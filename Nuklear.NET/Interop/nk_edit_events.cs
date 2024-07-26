namespace Nuklear.NET;

[Flags]
public enum NkEditEvents
{
    Active = (1 << (0)),
    Inactive = (1 << (1)),
    Activated = (1 << (2)),
    Deactivated = (1 << (3)),
    Commited = (1 << (4)),
}
