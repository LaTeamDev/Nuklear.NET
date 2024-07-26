using static Nuklear.NET.NkEditFlags;

namespace Nuklear.NET;

public enum NkEditTypes
{
    Simple = AlwaysInsertMode,
    Field = Simple | Selectable | Clipboard,
    Box = AlwaysInsertMode | Selectable | Multiline | AllowTab | Clipboard,
    Editor = Selectable | Multiline | AllowTab | Clipboard,
}
