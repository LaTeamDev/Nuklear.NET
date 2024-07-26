using static Nuklear.NET.NkPanelType;

namespace Nuklear.NET;

public enum NkPanelSet
{
    SetNonblock = Contextual | Combo | Menu | Tooltip,
    SetPopup = SetNonblock | Popup,
    SetSub = SetPopup | Group,
}
