using static Nuklear.NET.NkPanelFlags;

namespace Nuklear.NET;

public enum NkWindowFlags
{
    Private = (1 << (11)),
    Dynamic = Private,
    Rom = (1 << (12)),
    NotInteractive = Rom | NoInput,
    Hidden = (1 << (13)),
    Closed = (1 << (14)),
    Minimized = (1 << (15)),
    RemoveRom = (1 << (16)),
}
