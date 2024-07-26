using System.Runtime.InteropServices;

namespace Nuklear.NET; 

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void NkForeachAction(NkCommand* c);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void NkDrawForeachAction(NkDrawCommand* c);

public static unsafe partial class Nk {
    public static void Foreach(NkContext* ctx, NkForeachAction a) {
        NkCommand* c = null;

        for (c = _begin(ctx); c != null; c = _next(ctx, c))
            a(c);
    }

    public static void DrawForeach(NkContext* ctx, NkBuffer* b, NkDrawForeachAction a) {
        NkDrawCommand* cmd = null;

        for (cmd = _draw_begin(ctx, b); cmd != null; cmd = _draw_next(cmd, b, ctx))
            a(cmd);
    }
}