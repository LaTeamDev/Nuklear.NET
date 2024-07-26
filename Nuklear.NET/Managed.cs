using System.Runtime.InteropServices;

namespace Nuklear.NET; 

public unsafe partial class Nk {
    public static bool begin_titled(NkContext* ctx, string name, string title, NkRect bounds, uint flags) =>
       begin_titled(ctx, 
            (sbyte*) Marshal.StringToHGlobalAuto(name), 
            (sbyte*) Marshal.StringToHGlobalAuto(title), 
            bounds, 
            flags);

    public static bool window_is_closed(NkContext* ctx, string name) =>
        window_is_closed(ctx, (sbyte*)Marshal.StringToHGlobalAuto(name));
    
    public static bool window_is_hidden(NkContext* ctx, string name) =>
        window_is_hidden(ctx, (sbyte*)Marshal.StringToHGlobalAuto(name));
    
    public static bool window_is_collapsed(NkContext* ctx, string name) =>
        window_is_collapsed(ctx, (sbyte*)Marshal.StringToHGlobalAuto(name));
    
    public static bool group_begin_titled(NkContext* ctx, string name, string title, uint flags) =>
        group_begin_titled(ctx, 
            (sbyte*) Marshal.StringToHGlobalAuto(name), 
            (sbyte*) Marshal.StringToHGlobalAuto(title),
            flags);

    public static bool button_label(NkContext* ctx, string label) =>
        button_label(ctx, (sbyte*) Marshal.StringToHGlobalAuto(label));
    
    public static bool button_text(NkContext* ctx, string text) =>
        button_label(ctx, (sbyte*) Marshal.StringToHGlobalAuto(text));
    
    public static void label(NkContext* ctx, string text, uint textAlign) =>
        label(ctx, (sbyte*) Marshal.StringToHGlobalAuto(text), textAlign);

    public static void window_close(NkContext* ctx, string name) =>
        window_close(ctx, (sbyte*) Marshal.StringToHGlobalAuto(name));
}

public partial struct NkRect {
    public NkRect(float x, float y, float w, float h) {
        X = x;
        Y = y;
        W = w;
        H = h;
    }
}