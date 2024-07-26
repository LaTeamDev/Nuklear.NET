using static Nuklear.NET.NkTextAlign;

namespace Nuklear.NET;

public enum NkTextAlignment
{
    Left = AlignMiddle | AlignLeft,
    Centered = AlignMiddle | AlignCentered,
    Right = AlignMiddle | AlignRight,
}
