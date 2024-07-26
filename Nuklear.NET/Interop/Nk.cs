using System;
using System.Runtime.InteropServices;
using static Nuklear.NET.NkDrawVertexLayoutAttribute;

namespace Nuklear.NET;

public static unsafe partial class Nk
{
    public const int False = 0;
    public const int True = 1;

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_init_fixed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool init_fixed([NativeTypeName("struct nk_context *")] NkContext* param0, void* memory, [NativeTypeName("nk_size")] ulong size, [NativeTypeName("const struct nk_user_font *")] NkUserFont* param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_init", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool init([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_allocator *")] NkAllocator* param1, [NativeTypeName("const struct nk_user_font *")] NkUserFont* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_init_custom", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool init_custom([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_buffer *")] NkBuffer* cmds, [NativeTypeName("struct nk_buffer *")] NkBuffer* pool, [NativeTypeName("const struct nk_user_font *")] NkUserFont* param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_clear", ExactSpelling = true)]
    public static extern void clear([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_free", ExactSpelling = true)]
    public static extern void free([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_set_user_data", ExactSpelling = true)]
    public static extern void set_user_data([NativeTypeName("struct nk_context *")] NkContext* param0, NkHandle handle);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_begin", ExactSpelling = true)]
    public static extern void input_begin([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_motion", ExactSpelling = true)]
    public static extern void input_motion([NativeTypeName("struct nk_context *")] NkContext* param0, int x, int y);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_key", ExactSpelling = true)]
    public static extern void input_key([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_keys")] NkKeys param1, [NativeTypeName("nk_bool")] bool down);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_button", ExactSpelling = true)]
    public static extern void input_button([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1, int x, int y, [NativeTypeName("nk_bool")] bool down);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_scroll", ExactSpelling = true)]
    public static extern void input_scroll([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_vec2")] NkVec2 val);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_char", ExactSpelling = true)]
    public static extern void input_char([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("char")] sbyte param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_glyph", ExactSpelling = true)]
    public static extern void input_glyph([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const nk_glyph")] sbyte* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_unicode", ExactSpelling = true)]
    public static extern void input_unicode([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_rune")] uint param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_end", ExactSpelling = true)]
    public static extern void input_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk__begin", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_command *")]
    public static extern NkCommand* _begin([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk__next", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_command *")]
    public static extern NkCommand* _next([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_command *")] NkCommand* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_convert", ExactSpelling = true)]
    [return: NativeTypeName("nk_flags")]
    public static extern uint convert([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_buffer *")] NkBuffer* cmds, [NativeTypeName("struct nk_buffer *")] NkBuffer* vertices, [NativeTypeName("struct nk_buffer *")] NkBuffer* elements, [NativeTypeName("const struct nk_convert_config *")] NkConvertConfig* param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk__draw_begin", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_draw_command *")]
    public static extern NkDrawCommand* _draw_begin([NativeTypeName("const struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_buffer *")] NkBuffer* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk__draw_end", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_draw_command *")]
    public static extern NkDrawCommand* _draw_end([NativeTypeName("const struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_buffer *")] NkBuffer* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk__draw_next", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_draw_command *")]
    public static extern NkDrawCommand* _draw_next([NativeTypeName("const struct nk_draw_command *")] NkDrawCommand* param0, [NativeTypeName("const struct nk_buffer *")] NkBuffer* param1, [NativeTypeName("const struct nk_context *")] NkContext* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool begin([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("struct nk_rect")] NkRect bounds, [NativeTypeName("nk_flags")] uint flags);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_begin_titled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool begin_titled([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("struct nk_rect")] NkRect bounds, [NativeTypeName("nk_flags")] uint flags);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_end", ExactSpelling = true)]
    public static extern void end([NativeTypeName("struct nk_context *")] NkContext* ctx);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_find", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_window *")]
    public static extern NkWindow* window_find([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_bounds", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect window_get_bounds([NativeTypeName("const struct nk_context *")] NkContext* ctx);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_position", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 window_get_position([NativeTypeName("const struct nk_context *")] NkContext* ctx);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_size", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 window_get_size([NativeTypeName("const struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_width", ExactSpelling = true)]
    public static extern float window_get_width([NativeTypeName("const struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_height", ExactSpelling = true)]
    public static extern float window_get_height([NativeTypeName("const struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_panel", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_panel *")]
    public static extern NkPanel* window_get_panel([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_content_region", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect window_get_content_region([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_content_region_min", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 window_get_content_region_min([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_content_region_max", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 window_get_content_region_max([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_content_region_size", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 window_get_content_region_size([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_canvas", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_command_buffer *")]
    public static extern NkCommandBuffer* window_get_canvas([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_get_scroll", ExactSpelling = true)]
    public static extern void window_get_scroll([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_uint *")] uint* OffsetX, [NativeTypeName("nk_uint *")] uint* OffsetY);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_has_focus", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool window_has_focus([NativeTypeName("const struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_is_hovered", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool window_is_hovered([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_is_collapsed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool window_is_collapsed([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_is_closed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool window_is_closed([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_is_hidden", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool window_is_hidden([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_is_active", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool window_is_active([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_is_any_hovered", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool window_is_any_hovered([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_item_is_any_active", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool item_is_any_active([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_set_bounds", ExactSpelling = true)]
    public static extern void window_set_bounds([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct nk_rect")] NkRect bounds);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_set_position", ExactSpelling = true)]
    public static extern void window_set_position([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct nk_vec2")] NkVec2 pos);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_set_size", ExactSpelling = true)]
    public static extern void window_set_size([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("struct nk_vec2")] NkVec2 param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_set_focus", ExactSpelling = true)]
    public static extern void window_set_focus([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_set_scroll", ExactSpelling = true)]
    public static extern void window_set_scroll([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_uint")] uint OffsetX, [NativeTypeName("nk_uint")] uint OffsetY);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_close", ExactSpelling = true)]
    public static extern void window_close([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("const char *")] sbyte* name);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_collapse", ExactSpelling = true)]
    public static extern void window_collapse([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum nk_collapse_states")] NkCollapseStates state);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_collapse_if", ExactSpelling = true)]
    public static extern void window_collapse_if([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum nk_collapse_states")] NkCollapseStates param2, int cond);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_show", ExactSpelling = true)]
    public static extern void window_show([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum nk_show_states")] NkShowStates param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_window_show_if", ExactSpelling = true)]
    public static extern void window_show_if([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("enum nk_show_states")] NkShowStates param2, int cond);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_set_min_row_height", ExactSpelling = true)]
    public static extern void layout_set_min_row_height([NativeTypeName("struct nk_context *")] NkContext* param0, float height);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_reset_min_row_height", ExactSpelling = true)]
    public static extern void layout_reset_min_row_height([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_widget_bounds", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect layout_widget_bounds([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_ratio_from_pixel", ExactSpelling = true)]
    public static extern float layout_ratio_from_pixel([NativeTypeName("struct nk_context *")] NkContext* param0, float PixelWidth);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_dynamic", ExactSpelling = true)]
    public static extern void layout_row_dynamic([NativeTypeName("struct nk_context *")] NkContext* ctx, float height, int cols);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_static", ExactSpelling = true)]
    public static extern void layout_row_static([NativeTypeName("struct nk_context *")] NkContext* ctx, float height, int ItemWidth, int cols);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_begin", ExactSpelling = true)]
    public static extern void layout_row_begin([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("enum nk_layout_format")] NkLayoutFormat fmt, float RowHeight, int cols);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_push", ExactSpelling = true)]
    public static extern void layout_row_push([NativeTypeName("struct nk_context *")] NkContext* param0, float value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_end", ExactSpelling = true)]
    public static extern void layout_row_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row", ExactSpelling = true)]
    public static extern void layout_row([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_layout_format")] NkLayoutFormat param1, float height, int cols, [NativeTypeName("const float *")] float* ratio);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_template_begin", ExactSpelling = true)]
    public static extern void layout_row_template_begin([NativeTypeName("struct nk_context *")] NkContext* param0, float RowHeight);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_template_push_dynamic", ExactSpelling = true)]
    public static extern void layout_row_template_push_dynamic([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_template_push_variable", ExactSpelling = true)]
    public static extern void layout_row_template_push_variable([NativeTypeName("struct nk_context *")] NkContext* param0, float MinWidth);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_template_push_static", ExactSpelling = true)]
    public static extern void layout_row_template_push_static([NativeTypeName("struct nk_context *")] NkContext* param0, float width);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_row_template_end", ExactSpelling = true)]
    public static extern void layout_row_template_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_space_begin", ExactSpelling = true)]
    public static extern void layout_space_begin([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_layout_format")] NkLayoutFormat param1, float height, int WidgetCount);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_space_push", ExactSpelling = true)]
    public static extern void layout_space_push([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_rect")] NkRect bounds);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_space_end", ExactSpelling = true)]
    public static extern void layout_space_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_space_bounds", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect layout_space_bounds([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_space_to_screen", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 layout_space_to_screen([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_vec2")] NkVec2 param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_space_to_local", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 layout_space_to_local([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_vec2")] NkVec2 param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_space_rect_to_screen", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect layout_space_rect_to_screen([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_rect")] NkRect param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_layout_space_rect_to_local", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect layout_space_rect_to_local([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_rect")] NkRect param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_spacer", ExactSpelling = true)]
    public static extern void spacer([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_group_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool group_begin([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("nk_flags")] uint param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_group_begin_titled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool group_begin_titled([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("nk_flags")] uint param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_group_end", ExactSpelling = true)]
    public static extern void group_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_group_scrolled_offset_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool group_scrolled_offset_begin([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_uint *")] uint* XOffset, [NativeTypeName("nk_uint *")] uint* YOffset, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("nk_flags")] uint flags);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_group_scrolled_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool group_scrolled_begin([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_scroll *")] NkScroll* off, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("nk_flags")] uint param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_group_scrolled_end", ExactSpelling = true)]
    public static extern void group_scrolled_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_group_get_scroll", ExactSpelling = true)]
    public static extern void group_get_scroll([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* id, [NativeTypeName("nk_uint *")] uint* XOffset, [NativeTypeName("nk_uint *")] uint* YOffset);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_group_set_scroll", ExactSpelling = true)]
    public static extern void group_set_scroll([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* id, [NativeTypeName("nk_uint")] uint XOffset, [NativeTypeName("nk_uint")] uint YOffset);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_push_hashed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool tree_push_hashed([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_tree_type")] NkTreeType param1, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("enum nk_collapse_states")] NkCollapseStates InitialState, [NativeTypeName("const char *")] sbyte* hash, int len, int seed);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_image_push_hashed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool tree_image_push_hashed([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_tree_type")] NkTreeType param1, [NativeTypeName("struct nk_image")] NkImage param2, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("enum nk_collapse_states")] NkCollapseStates InitialState, [NativeTypeName("const char *")] sbyte* hash, int len, int seed);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_pop", ExactSpelling = true)]
    public static extern void tree_pop([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_state_push", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool tree_state_push([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_tree_type")] NkTreeType param1, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("enum nk_collapse_states *")] NkCollapseStates* state);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_state_image_push", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool tree_state_image_push([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_tree_type")] NkTreeType param1, [NativeTypeName("struct nk_image")] NkImage param2, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("enum nk_collapse_states *")] NkCollapseStates* state);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_state_pop", ExactSpelling = true)]
    public static extern void tree_state_pop([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_element_push_hashed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool tree_element_push_hashed([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_tree_type")] NkTreeType param1, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("enum nk_collapse_states")] NkCollapseStates InitialState, [NativeTypeName("nk_bool *")] bool* selected, [NativeTypeName("const char *")] sbyte* hash, int len, int seed);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_element_image_push_hashed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool tree_element_image_push_hashed([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_tree_type")] NkTreeType param1, [NativeTypeName("struct nk_image")] NkImage param2, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("enum nk_collapse_states")] NkCollapseStates InitialState, [NativeTypeName("nk_bool *")] bool* selected, [NativeTypeName("const char *")] sbyte* hash, int len, int seed);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tree_element_pop", ExactSpelling = true)]
    public static extern void tree_element_pop([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_list_view_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool list_view_begin([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_list_view *")] NkListView* @out, [NativeTypeName("const char *")] sbyte* id, [NativeTypeName("nk_flags")] uint param3, int RowHeight, int RowCount);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_list_view_end", ExactSpelling = true)]
    public static extern void list_view_end([NativeTypeName("struct nk_list_view *")] NkListView* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget", ExactSpelling = true)]
    [return: NativeTypeName("enum nk_widget_layout_states")]
    public static extern NkWidgetLayoutStates widget([NativeTypeName("struct nk_rect *")] NkRect* param0, [NativeTypeName("const struct nk_context *")] NkContext* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_fitting", ExactSpelling = true)]
    [return: NativeTypeName("enum nk_widget_layout_states")]
    public static extern NkWidgetLayoutStates widget_fitting([NativeTypeName("struct nk_rect *")] NkRect* param0, [NativeTypeName("struct nk_context *")] NkContext* param1, [NativeTypeName("struct nk_vec2")] NkVec2 param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_bounds", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect widget_bounds([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_position", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 widget_position([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_size", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 widget_size([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_width", ExactSpelling = true)]
    public static extern float widget_width([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_height", ExactSpelling = true)]
    public static extern float widget_height([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_is_hovered", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool widget_is_hovered([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_is_mouse_clicked", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool widget_is_mouse_clicked([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_widget_has_mouse_click_down", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool widget_has_mouse_click_down([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1, [NativeTypeName("nk_bool")] bool down);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_spacing", ExactSpelling = true)]
    public static extern void spacing([NativeTypeName("struct nk_context *")] NkContext* param0, int cols);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_text", ExactSpelling = true)]
    public static extern void text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_text_colored", ExactSpelling = true)]
    public static extern void text_colored([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint param3, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_text_wrap", ExactSpelling = true)]
    public static extern void text_wrap([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_text_wrap_colored", ExactSpelling = true)]
    public static extern void text_wrap_colored([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_label", ExactSpelling = true)]
    public static extern void label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint align);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_label_colored", ExactSpelling = true)]
    public static extern void label_colored([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_label_wrap", ExactSpelling = true)]
    public static extern void label_wrap([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_label_colored_wrap", ExactSpelling = true)]
    public static extern void label_colored_wrap([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("struct nk_color")] NkColor param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_image", ExactSpelling = true)]
    public static extern void image([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_image_color", ExactSpelling = true)]
    public static extern void image_color([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("struct nk_color")] NkColor param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* title, int len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* title);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_color", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_color([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_symbol", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_symbol([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_image", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_image([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage img);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_symbol_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_symbol_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint TextAlignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_symbol_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_symbol_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_image_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_image_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage img, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint TextAlignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_image_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_image_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage img, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_text_styled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_text_styled([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_style_button *")] NkStyleButton* param1, [NativeTypeName("const char *")] sbyte* title, int len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_label_styled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_label_styled([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_style_button *")] NkStyleButton* param1, [NativeTypeName("const char *")] sbyte* title);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_symbol_styled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_symbol_styled([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_style_button *")] NkStyleButton* param1, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_image_styled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_image_styled([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_style_button *")] NkStyleButton* param1, [NativeTypeName("struct nk_image")] NkImage img);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_symbol_text_styled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_symbol_text_styled([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_style_button *")] NkStyleButton* param1, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param2, [NativeTypeName("const char *")] sbyte* param3, int param4, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_symbol_label_styled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_symbol_label_styled([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("const struct nk_style_button *")] NkStyleButton* style, [NativeTypeName("enum nk_symbol_type")] NkSymbolType symbol, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("nk_flags")] uint align);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_image_label_styled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_image_label_styled([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_style_button *")] NkStyleButton* param1, [NativeTypeName("struct nk_image")] NkImage img, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("nk_flags")] uint TextAlignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_image_text_styled", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_image_text_styled([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_style_button *")] NkStyleButton* param1, [NativeTypeName("struct nk_image")] NkImage img, [NativeTypeName("const char *")] sbyte* param3, int param4, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_set_behavior", ExactSpelling = true)]
    public static extern void button_set_behavior([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_button_behavior")] NkButtonBehavior param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_push_behavior", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_push_behavior([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_button_behavior")] NkButtonBehavior param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_button_pop_behavior", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool button_pop_behavior([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_check_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool check_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_bool")] bool active);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_check_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool check_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_bool")] bool active);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_check_flags_label", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint check_flags_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("unsigned int")] uint flags, [NativeTypeName("unsigned int")] uint value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_check_flags_text", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint check_flags_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("unsigned int")] uint flags, [NativeTypeName("unsigned int")] uint value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_checkbox_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool checkbox_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_bool *")] bool* active);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_checkbox_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool checkbox_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_bool *")] bool* active);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_checkbox_flags_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool checkbox_flags_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("unsigned int *")] uint* flags, [NativeTypeName("unsigned int")] uint value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_checkbox_flags_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool checkbox_flags_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("unsigned int *")] uint* flags, [NativeTypeName("unsigned int")] uint value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_radio_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool radio_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_bool *")] bool* active);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_radio_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool radio_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_bool *")] bool* active);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_option_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool option_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_bool")] bool active);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_option_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool option_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_bool")] bool active);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_selectable_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool selectable_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool *")] bool* value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_selectable_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool selectable_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool *")] bool* value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_selectable_image_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool selectable_image_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool *")] bool* value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_selectable_image_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool selectable_image_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool *")] bool* value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_selectable_symbol_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool selectable_symbol_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool *")] bool* value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_selectable_symbol_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool selectable_symbol_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool *")] bool* value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_select_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool select_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool")] bool value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_select_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool select_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool")] bool value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_select_image_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool select_image_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool")] bool value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_select_image_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool select_image_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool")] bool value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_select_symbol_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool select_symbol_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool")] bool value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_select_symbol_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool select_symbol_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("nk_bool")] bool value);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_slide_float", ExactSpelling = true)]
    public static extern float slide_float([NativeTypeName("struct nk_context *")] NkContext* param0, float min, float val, float max, float step);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_slide_int", ExactSpelling = true)]
    public static extern int slide_int([NativeTypeName("struct nk_context *")] NkContext* param0, int min, int val, int max, int step);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_slider_float", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool slider_float([NativeTypeName("struct nk_context *")] NkContext* param0, float min, float* val, float max, float step);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_slider_int", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool slider_int([NativeTypeName("struct nk_context *")] NkContext* param0, int min, int* val, int max, int step);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_progress", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool progress([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_size *")] ulong* cur, [NativeTypeName("nk_size")] ulong max, [NativeTypeName("nk_bool")] bool modifyable);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_prog", ExactSpelling = true)]
    [return: NativeTypeName("nk_size")]
    public static extern ulong prog([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_size")] ulong cur, [NativeTypeName("nk_size")] ulong max, [NativeTypeName("nk_bool")] bool modifyable);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_picker", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_colorf")]
    public static extern NkColorf color_picker([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_colorf")] NkColorf param1, [NativeTypeName("enum nk_color_format")] NkColorFormat param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_pick", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool color_pick([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_colorf *")] NkColorf* param1, [NativeTypeName("enum nk_color_format")] NkColorFormat param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_property_int", ExactSpelling = true)]
    public static extern void property_int([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, int min, int* val, int max, int step, float IncPerPixel);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_property_float", ExactSpelling = true)]
    public static extern void property_float([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, float min, float* val, float max, float step, float IncPerPixel);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_property_double", ExactSpelling = true)]
    public static extern void property_double([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, double min, double* val, double max, double step, float IncPerPixel);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_propertyi", ExactSpelling = true)]
    public static extern int propertyi([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, int min, int val, int max, int step, float IncPerPixel);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_propertyf", ExactSpelling = true)]
    public static extern float propertyf([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, float min, float val, float max, float step, float IncPerPixel);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_propertyd", ExactSpelling = true)]
    public static extern double propertyd([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* name, double min, double val, double max, double step, float IncPerPixel);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_edit_string", ExactSpelling = true)]
    [return: NativeTypeName("nk_flags")]
    public static extern uint edit_string([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_flags")] uint param1, [NativeTypeName("char *")] sbyte* buffer, int* len, int max, [NativeTypeName("nk_plugin_filter")] delegate* unmanaged[Cdecl]<NkTextEdit*, uint, bool> param5);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_edit_string_zero_terminated", ExactSpelling = true)]
    [return: NativeTypeName("nk_flags")]
    public static extern uint edit_string_zero_terminated([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_flags")] uint param1, [NativeTypeName("char *")] sbyte* buffer, int max, [NativeTypeName("nk_plugin_filter")] delegate* unmanaged[Cdecl]<NkTextEdit*, uint, bool> param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_edit_buffer", ExactSpelling = true)]
    [return: NativeTypeName("nk_flags")]
    public static extern uint edit_buffer([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_flags")] uint param1, [NativeTypeName("struct nk_text_edit *")] NkTextEdit* param2, [NativeTypeName("nk_plugin_filter")] delegate* unmanaged[Cdecl]<NkTextEdit*, uint, bool> param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_edit_focus", ExactSpelling = true)]
    public static extern void edit_focus([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_flags")] uint flags);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_edit_unfocus", ExactSpelling = true)]
    public static extern void edit_unfocus([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_chart_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool chart_begin([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_chart_type")] NkChartType param1, int num, float min, float max);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_chart_begin_colored", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool chart_begin_colored([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_chart_type")] NkChartType param1, [NativeTypeName("struct nk_color")] NkColor param2, [NativeTypeName("struct nk_color")] NkColor active, int num, float min, float max);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_chart_add_slot", ExactSpelling = true)]
    public static extern void chart_add_slot([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("const enum nk_chart_type")] NkChartType param1, int count, float MinValue, float MaxValue);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_chart_add_slot_colored", ExactSpelling = true)]
    public static extern void chart_add_slot_colored([NativeTypeName("struct nk_context *")] NkContext* ctx, [NativeTypeName("const enum nk_chart_type")] NkChartType param1, [NativeTypeName("struct nk_color")] NkColor param2, [NativeTypeName("struct nk_color")] NkColor active, int count, float MinValue, float MaxValue);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_chart_push", ExactSpelling = true)]
    [return: NativeTypeName("nk_flags")]
    public static extern uint chart_push([NativeTypeName("struct nk_context *")] NkContext* param0, float param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_chart_push_slot", ExactSpelling = true)]
    [return: NativeTypeName("nk_flags")]
    public static extern uint chart_push_slot([NativeTypeName("struct nk_context *")] NkContext* param0, float param1, int param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_chart_end", ExactSpelling = true)]
    public static extern void chart_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_plot", ExactSpelling = true)]
    public static extern void plot([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_chart_type")] NkChartType param1, [NativeTypeName("const float *")] float* values, int count, int offset);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_plot_function", ExactSpelling = true)]
    public static extern void plot_function([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_chart_type")] NkChartType param1, void* userdata, [NativeTypeName("float (*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, float> ValueGetter, int count, int offset);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_popup_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool popup_begin([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_popup_type")] NkPopupType param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint param3, [NativeTypeName("struct nk_rect")] NkRect bounds);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_popup_close", ExactSpelling = true)]
    public static extern void popup_close([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_popup_end", ExactSpelling = true)]
    public static extern void popup_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_popup_get_scroll", ExactSpelling = true)]
    public static extern void popup_get_scroll([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_uint *")] uint* OffsetX, [NativeTypeName("nk_uint *")] uint* OffsetY);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_popup_set_scroll", ExactSpelling = true)]
    public static extern void popup_set_scroll([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_uint")] uint OffsetX, [NativeTypeName("nk_uint")] uint OffsetY);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo", ExactSpelling = true)]
    public static extern int combo([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char **")] sbyte** items, int count, int selected, int ItemHeight, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_separator", ExactSpelling = true)]
    public static extern int combo_separator([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* ItemsSeparatedBySeparator, int separator, int selected, int count, int ItemHeight, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_string", ExactSpelling = true)]
    public static extern int combo_string([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* ItemsSeparatedByZeros, int selected, int count, int ItemHeight, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_callback", ExactSpelling = true)]
    public static extern int combo_callback([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("void (*)(void *, int, const char **)")] delegate* unmanaged[Cdecl]<void*, int, sbyte**, void> ItemGetter, void* userdata, int selected, int count, int ItemHeight, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combobox", ExactSpelling = true)]
    public static extern void combobox([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char **")] sbyte** items, int count, int* selected, int ItemHeight, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combobox_string", ExactSpelling = true)]
    public static extern void combobox_string([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* ItemsSeparatedByZeros, int* selected, int count, int ItemHeight, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combobox_separator", ExactSpelling = true)]
    public static extern void combobox_separator([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* ItemsSeparatedBySeparator, int separator, int* selected, int count, int ItemHeight, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combobox_callback", ExactSpelling = true)]
    public static extern void combobox_callback([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("void (*)(void *, int, const char **)")] delegate* unmanaged[Cdecl]<void*, int, sbyte**, void> ItemGetter, void* param2, int* selected, int count, int ItemHeight, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* selected, int param2, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* selected, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_color", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_color([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_color")] NkColor color, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_symbol", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_symbol([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_symbol_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_symbol_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* selected, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param2, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_symbol_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_symbol_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* selected, int param2, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param3, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_image", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_image([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage img, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_image_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_image_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* selected, [NativeTypeName("struct nk_image")] NkImage param2, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_begin_image_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_begin_image_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* selected, int param2, [NativeTypeName("struct nk_image")] NkImage param3, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_item_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_item_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_item_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_item_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_item_image_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_item_image_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_item_image_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_item_image_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_item_symbol_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_item_symbol_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_item_symbol_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool combo_item_symbol_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_close", ExactSpelling = true)]
    public static extern void combo_close([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_combo_end", ExactSpelling = true)]
    public static extern void combo_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool contextual_begin([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_flags")] uint param1, [NativeTypeName("struct nk_vec2")] NkVec2 param2, [NativeTypeName("struct nk_rect")] NkRect TriggerBounds);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_item_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool contextual_item_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint align);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_item_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool contextual_item_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint align);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_item_image_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool contextual_item_image_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_item_image_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool contextual_item_image_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, int len, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_item_symbol_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool contextual_item_symbol_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_item_symbol_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool contextual_item_symbol_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_close", ExactSpelling = true)]
    public static extern void contextual_close([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_contextual_end", ExactSpelling = true)]
    public static extern void contextual_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tooltip", ExactSpelling = true)]
    public static extern void tooltip([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tooltip_begin", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool tooltip_begin([NativeTypeName("struct nk_context *")] NkContext* param0, float width);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_tooltip_end", ExactSpelling = true)]
    public static extern void tooltip_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menubar_begin", ExactSpelling = true)]
    public static extern void menubar_begin([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menubar_end", ExactSpelling = true)]
    public static extern void menubar_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_begin_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_begin_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* title, int TitleLen, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_begin_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_begin_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_begin_image", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_begin_image([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("struct nk_image")] NkImage param2, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_begin_image_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_begin_image_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("struct nk_image")] NkImage param4, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_begin_image_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_begin_image_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("struct nk_image")] NkImage param3, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_begin_symbol", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_begin_symbol([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param2, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_begin_symbol_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_begin_symbol_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param4, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_begin_symbol_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_begin_symbol_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint align, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param3, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_item_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_item_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, [NativeTypeName("nk_flags")] uint align);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_item_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_item_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_item_image_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_item_image_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_item_image_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_item_image_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_image")] NkImage param1, [NativeTypeName("const char *")] sbyte* param2, int len, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_item_symbol_text", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_item_symbol_text([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, int param3, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_item_symbol_label", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool menu_item_symbol_label([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_symbol_type")] NkSymbolType param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("nk_flags")] uint alignment);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_close", ExactSpelling = true)]
    public static extern void menu_close([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_menu_end", ExactSpelling = true)]
    public static extern void menu_end([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_default", ExactSpelling = true)]
    public static extern void style_default([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_from_table", ExactSpelling = true)]
    public static extern void style_from_table([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_color *")] NkColor* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_load_cursor", ExactSpelling = true)]
    public static extern void style_load_cursor([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_style_cursor")] NkStyleCursor param1, [NativeTypeName("const struct nk_cursor *")] NkCursor* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_load_all_cursors", ExactSpelling = true)]
    public static extern void style_load_all_cursors([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_cursor *")] NkCursor* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_get_color_by_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* style_get_color_by_name([NativeTypeName("enum nk_style_colors")] NkStyleColors param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_set_font", ExactSpelling = true)]
    public static extern void style_set_font([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_user_font *")] NkUserFont* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_set_cursor", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_set_cursor([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("enum nk_style_cursor")] NkStyleCursor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_show_cursor", ExactSpelling = true)]
    public static extern void style_show_cursor([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_hide_cursor", ExactSpelling = true)]
    public static extern void style_hide_cursor([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_push_font", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_push_font([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("const struct nk_user_font *")] NkUserFont* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_push_float", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_push_float([NativeTypeName("struct nk_context *")] NkContext* param0, float* param1, float param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_push_vec2", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_push_vec2([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_vec2 *")] NkVec2* param1, [NativeTypeName("struct nk_vec2")] NkVec2 param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_push_style_item", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_push_style_item([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_style_item *")] NkStyleItem* param1, [NativeTypeName("struct nk_style_item")] NkStyleItem param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_push_flags", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_push_flags([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("nk_flags *")] uint* param1, [NativeTypeName("nk_flags")] uint param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_push_color", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_push_color([NativeTypeName("struct nk_context *")] NkContext* param0, [NativeTypeName("struct nk_color *")] NkColor* param1, [NativeTypeName("struct nk_color")] NkColor param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_pop_font", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_pop_font([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_pop_float", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_pop_float([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_pop_vec2", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_pop_vec2([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_pop_style_item", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_pop_style_item([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_pop_flags", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_pop_flags([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_pop_color", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool style_pop_color([NativeTypeName("struct nk_context *")] NkContext* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgb", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgb(int r, int g, int b);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgb_iv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgb_iv([NativeTypeName("const int *")] int* rgb);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgb_bv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgb_bv([NativeTypeName("const nk_byte *")] byte* rgb);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgb_f", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgb_f(float r, float g, float b);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgb_fv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgb_fv([NativeTypeName("const float *")] float* rgb);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgb_cf", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgb_cf([NativeTypeName("struct nk_colorf")] NkColorf c);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgb_hex", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgb_hex([NativeTypeName("const char *")] sbyte* rgb);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgba", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgba(int r, int g, int b, int a);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgba_u32", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgba_u32([NativeTypeName("nk_uint")] uint param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgba_iv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgba_iv([NativeTypeName("const int *")] int* rgba);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgba_bv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgba_bv([NativeTypeName("const nk_byte *")] byte* rgba);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgba_f", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgba_f(float r, float g, float b, float a);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgba_fv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgba_fv([NativeTypeName("const float *")] float* rgba);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgba_cf", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgba_cf([NativeTypeName("struct nk_colorf")] NkColorf c);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rgba_hex", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor rgba_hex([NativeTypeName("const char *")] sbyte* rgb);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsva_colorf", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_colorf")]
    public static extern NkColorf hsva_colorf(float h, float s, float v, float a);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsva_colorfv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_colorf")]
    public static extern NkColorf hsva_colorfv(float* c);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_colorf_hsva_f", ExactSpelling = true)]
    public static extern void colorf_hsva_f(float* OutH, float* OutS, float* OutV, float* OutA, [NativeTypeName("struct nk_colorf")] NkColorf @in);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_colorf_hsva_fv", ExactSpelling = true)]
    public static extern void colorf_hsva_fv(float* hsva, [NativeTypeName("struct nk_colorf")] NkColorf @in);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsv(int h, int s, int v);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsv_iv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsv_iv([NativeTypeName("const int *")] int* hsv);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsv_bv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsv_bv([NativeTypeName("const nk_byte *")] byte* hsv);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsv_f", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsv_f(float h, float s, float v);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsv_fv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsv_fv([NativeTypeName("const float *")] float* hsv);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsva", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsva(int h, int s, int v, int a);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsva_iv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsva_iv([NativeTypeName("const int *")] int* hsva);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsva_bv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsva_bv([NativeTypeName("const nk_byte *")] byte* hsva);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsva_f", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsva_f(float h, float s, float v, float a);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_hsva_fv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_color")]
    public static extern NkColor hsva_fv([NativeTypeName("const float *")] float* hsva);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_f", ExactSpelling = true)]
    public static extern void color_f(float* r, float* g, float* b, float* a, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_fv", ExactSpelling = true)]
    public static extern void color_fv(float* RgbaOut, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_cf", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_colorf")]
    public static extern NkColorf color_cf([NativeTypeName("struct nk_color")] NkColor param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_d", ExactSpelling = true)]
    public static extern void color_d(double* r, double* g, double* b, double* a, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_dv", ExactSpelling = true)]
    public static extern void color_dv(double* RgbaOut, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_u32", ExactSpelling = true)]
    [return: NativeTypeName("nk_uint")]
    public static extern uint color_u32([NativeTypeName("struct nk_color")] NkColor param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hex_rgba", ExactSpelling = true)]
    public static extern void color_hex_rgba([NativeTypeName("char *")] sbyte* output, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hex_rgb", ExactSpelling = true)]
    public static extern void color_hex_rgb([NativeTypeName("char *")] sbyte* output, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsv_i", ExactSpelling = true)]
    public static extern void color_hsv_i(int* OutH, int* OutS, int* OutV, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsv_b", ExactSpelling = true)]
    public static extern void color_hsv_b([NativeTypeName("nk_byte *")] byte* OutH, [NativeTypeName("nk_byte *")] byte* OutS, [NativeTypeName("nk_byte *")] byte* OutV, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsv_iv", ExactSpelling = true)]
    public static extern void color_hsv_iv(int* HsvOut, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsv_bv", ExactSpelling = true)]
    public static extern void color_hsv_bv([NativeTypeName("nk_byte *")] byte* HsvOut, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsv_f", ExactSpelling = true)]
    public static extern void color_hsv_f(float* OutH, float* OutS, float* OutV, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsv_fv", ExactSpelling = true)]
    public static extern void color_hsv_fv(float* HsvOut, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsva_i", ExactSpelling = true)]
    public static extern void color_hsva_i(int* h, int* s, int* v, int* a, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsva_b", ExactSpelling = true)]
    public static extern void color_hsva_b([NativeTypeName("nk_byte *")] byte* h, [NativeTypeName("nk_byte *")] byte* s, [NativeTypeName("nk_byte *")] byte* v, [NativeTypeName("nk_byte *")] byte* a, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsva_iv", ExactSpelling = true)]
    public static extern void color_hsva_iv(int* HsvaOut, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsva_bv", ExactSpelling = true)]
    public static extern void color_hsva_bv([NativeTypeName("nk_byte *")] byte* HsvaOut, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsva_f", ExactSpelling = true)]
    public static extern void color_hsva_f(float* OutH, float* OutS, float* OutV, float* OutA, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_color_hsva_fv", ExactSpelling = true)]
    public static extern void color_hsva_fv(float* HsvaOut, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_handle_ptr", ExactSpelling = true)]
    public static extern NkHandle handle_ptr(void* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_handle_id", ExactSpelling = true)]
    public static extern NkHandle handle_id(int param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_image_handle", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_image")]
    public static extern NkImage image_handle(NkHandle param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_image_ptr", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_image")]
    public static extern NkImage image_ptr(void* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_image_id", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_image")]
    public static extern NkImage image_id(int param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_image_is_subimage", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool image_is_subimage([NativeTypeName("const struct nk_image *")] NkImage* img);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_subimage_ptr", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_image")]
    public static extern NkImage subimage_ptr(void* param0, [NativeTypeName("nk_ushort")] ushort w, [NativeTypeName("nk_ushort")] ushort h, [NativeTypeName("struct nk_rect")] NkRect SubRegion);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_subimage_id", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_image")]
    public static extern NkImage subimage_id(int param0, [NativeTypeName("nk_ushort")] ushort w, [NativeTypeName("nk_ushort")] ushort h, [NativeTypeName("struct nk_rect")] NkRect SubRegion);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_subimage_handle", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_image")]
    public static extern NkImage subimage_handle(NkHandle param0, [NativeTypeName("nk_ushort")] ushort w, [NativeTypeName("nk_ushort")] ushort h, [NativeTypeName("struct nk_rect")] NkRect SubRegion);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_nine_slice_handle", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_nine_slice")]
    public static extern NkNineSlice nine_slice_handle(NkHandle param0, [NativeTypeName("nk_ushort")] ushort l, [NativeTypeName("nk_ushort")] ushort t, [NativeTypeName("nk_ushort")] ushort r, [NativeTypeName("nk_ushort")] ushort b);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_nine_slice_ptr", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_nine_slice")]
    public static extern NkNineSlice nine_slice_ptr(void* param0, [NativeTypeName("nk_ushort")] ushort l, [NativeTypeName("nk_ushort")] ushort t, [NativeTypeName("nk_ushort")] ushort r, [NativeTypeName("nk_ushort")] ushort b);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_nine_slice_id", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_nine_slice")]
    public static extern NkNineSlice nine_slice_id(int param0, [NativeTypeName("nk_ushort")] ushort l, [NativeTypeName("nk_ushort")] ushort t, [NativeTypeName("nk_ushort")] ushort r, [NativeTypeName("nk_ushort")] ushort b);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_nine_slice_is_sub9slice", ExactSpelling = true)]
    public static extern int nine_slice_is_sub9slice([NativeTypeName("const struct nk_nine_slice *")] NkNineSlice* img);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_sub9slice_ptr", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_nine_slice")]
    public static extern NkNineSlice sub9slice_ptr(void* param0, [NativeTypeName("nk_ushort")] ushort w, [NativeTypeName("nk_ushort")] ushort h, [NativeTypeName("struct nk_rect")] NkRect SubRegion, [NativeTypeName("nk_ushort")] ushort l, [NativeTypeName("nk_ushort")] ushort t, [NativeTypeName("nk_ushort")] ushort r, [NativeTypeName("nk_ushort")] ushort b);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_sub9slice_id", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_nine_slice")]
    public static extern NkNineSlice sub9slice_id(int param0, [NativeTypeName("nk_ushort")] ushort w, [NativeTypeName("nk_ushort")] ushort h, [NativeTypeName("struct nk_rect")] NkRect SubRegion, [NativeTypeName("nk_ushort")] ushort l, [NativeTypeName("nk_ushort")] ushort t, [NativeTypeName("nk_ushort")] ushort r, [NativeTypeName("nk_ushort")] ushort b);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_sub9slice_handle", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_nine_slice")]
    public static extern NkNineSlice sub9slice_handle(NkHandle param0, [NativeTypeName("nk_ushort")] ushort w, [NativeTypeName("nk_ushort")] ushort h, [NativeTypeName("struct nk_rect")] NkRect SubRegion, [NativeTypeName("nk_ushort")] ushort l, [NativeTypeName("nk_ushort")] ushort t, [NativeTypeName("nk_ushort")] ushort r, [NativeTypeName("nk_ushort")] ushort b);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_murmur_hash", ExactSpelling = true)]
    [return: NativeTypeName("nk_hash")]
    public static extern uint murmur_hash([NativeTypeName("const void *")] void* key, int len, [NativeTypeName("nk_hash")] uint seed);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_triangle_from_direction", ExactSpelling = true)]
    public static extern void triangle_from_direction([NativeTypeName("struct nk_vec2 *")] NkVec2* result, [NativeTypeName("struct nk_rect")] NkRect r, float PadX, float PadY, [NativeTypeName("enum nk_heading")] NkHeading param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_vec2", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 vec2(float x, float y);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_vec2i", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 vec2i(int x, int y);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_vec2v", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 vec2v([NativeTypeName("const float *")] float* xy);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_vec2iv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 vec2iv([NativeTypeName("const int *")] int* xy);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_get_null_rect", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect get_null_rect();

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rect", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect rect(float x, float y, float w, float h);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_recti", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect recti(int x, int y, int w, int h);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_recta", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect recta([NativeTypeName("struct nk_vec2")] NkVec2 pos, [NativeTypeName("struct nk_vec2")] NkVec2 size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rectv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect rectv([NativeTypeName("const float *")] float* xywh);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rectiv", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_rect")]
    public static extern NkRect rectiv([NativeTypeName("const int *")] int* xywh);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rect_pos", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 rect_pos([NativeTypeName("struct nk_rect")] NkRect param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_rect_size", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_vec2")]
    public static extern NkVec2 rect_size([NativeTypeName("struct nk_rect")] NkRect param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_strlen", ExactSpelling = true)]
    public static extern int strlen([NativeTypeName("const char *")] sbyte* str);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stricmp", ExactSpelling = true)]
    public static extern int stricmp([NativeTypeName("const char *")] sbyte* s1, [NativeTypeName("const char *")] sbyte* s2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stricmpn", ExactSpelling = true)]
    public static extern int stricmpn([NativeTypeName("const char *")] sbyte* s1, [NativeTypeName("const char *")] sbyte* s2, int n);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_strtoi", ExactSpelling = true)]
    public static extern int strtoi([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char **")] sbyte** endptr);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_strtof", ExactSpelling = true)]
    public static extern float strtof([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char **")] sbyte** endptr);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_strtod", ExactSpelling = true)]
    public static extern double strtod([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char **")] sbyte** endptr);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_strfilter", ExactSpelling = true)]
    public static extern int strfilter([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* regexp);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_strmatch_fuzzy_string", ExactSpelling = true)]
    public static extern int strmatch_fuzzy_string([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* pattern, int* OutScore);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_strmatch_fuzzy_text", ExactSpelling = true)]
    public static extern int strmatch_fuzzy_text([NativeTypeName("const char *")] sbyte* txt, int TxtLen, [NativeTypeName("const char *")] sbyte* pattern, int* OutScore);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_utf_decode", ExactSpelling = true)]
    public static extern int utf_decode([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("nk_rune *")] uint* param1, int param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_utf_encode", ExactSpelling = true)]
    public static extern int utf_encode([NativeTypeName("nk_rune")] uint param0, [NativeTypeName("char *")] sbyte* param1, int param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_utf_len", ExactSpelling = true)]
    public static extern int utf_len([NativeTypeName("const char *")] sbyte* param0, int ByteLen);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_utf_at", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* utf_at([NativeTypeName("const char *")] sbyte* buffer, int length, int index, [NativeTypeName("nk_rune *")] uint* unicode, int* len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_default_glyph_ranges", ExactSpelling = true)]
    [return: NativeTypeName("const nk_rune *")]
    public static extern uint* font_default_glyph_ranges();

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_chinese_glyph_ranges", ExactSpelling = true)]
    [return: NativeTypeName("const nk_rune *")]
    public static extern uint* font_chinese_glyph_ranges();

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_cyrillic_glyph_ranges", ExactSpelling = true)]
    [return: NativeTypeName("const nk_rune *")]
    public static extern uint* font_cyrillic_glyph_ranges();

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_korean_glyph_ranges", ExactSpelling = true)]
    [return: NativeTypeName("const nk_rune *")]
    public static extern uint* font_korean_glyph_ranges();

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_init", ExactSpelling = true)]
    public static extern void font_atlas_init([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0, [NativeTypeName("struct nk_allocator *")] NkAllocator* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_init_custom", ExactSpelling = true)]
    public static extern void font_atlas_init_custom([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0, [NativeTypeName("struct nk_allocator *")] NkAllocator* persistent, [NativeTypeName("struct nk_allocator *")] NkAllocator* transient);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_begin", ExactSpelling = true)]
    public static extern void font_atlas_begin([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_config", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_font_config")]
    public static extern NkFontConfig font_config(float PixelHeight);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_add", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_font *")]
    public static extern NkFont* font_atlas_add([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0, [NativeTypeName("const struct nk_font_config *")] NkFontConfig* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_add_default", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_font *")]
    public static extern NkFont* font_atlas_add_default([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0, float height, [NativeTypeName("const struct nk_font_config *")] NkFontConfig* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_add_from_memory", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_font *")]
    public static extern NkFont* font_atlas_add_from_memory([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* atlas, void* memory, [NativeTypeName("nk_size")] ulong size, float height, [NativeTypeName("const struct nk_font_config *")] NkFontConfig* config);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_add_compressed", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_font *")]
    public static extern NkFont* font_atlas_add_compressed([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0, void* memory, [NativeTypeName("nk_size")] ulong size, float height, [NativeTypeName("const struct nk_font_config *")] NkFontConfig* param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_add_compressed_base85", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_font *")]
    public static extern NkFont* font_atlas_add_compressed_base85([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0, [NativeTypeName("const char *")] sbyte* data, float height, [NativeTypeName("const struct nk_font_config *")] NkFontConfig* config);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_bake", ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* font_atlas_bake([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0, int* width, int* height, [NativeTypeName("enum nk_font_atlas_format")] NkFontAtlasFormat param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_end", ExactSpelling = true)]
    public static extern void font_atlas_end([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0, NkHandle tex, [NativeTypeName("struct nk_draw_null_texture *")] NkDrawNullTexture* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_find_glyph", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_font_glyph *")]
    public static extern NkFontGlyph* font_find_glyph([NativeTypeName("struct nk_font *")] NkFont* param0, [NativeTypeName("nk_rune")] uint unicode);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_cleanup", ExactSpelling = true)]
    public static extern void font_atlas_cleanup([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* atlas);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_font_atlas_clear", ExactSpelling = true)]
    public static extern void font_atlas_clear([NativeTypeName("struct nk_font_atlas *")] NkFontAtlas* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_init", ExactSpelling = true)]
    public static extern void buffer_init([NativeTypeName("struct nk_buffer *")] NkBuffer* param0, [NativeTypeName("const struct nk_allocator *")] NkAllocator* param1, [NativeTypeName("nk_size")] ulong size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_init_fixed", ExactSpelling = true)]
    public static extern void buffer_init_fixed([NativeTypeName("struct nk_buffer *")] NkBuffer* param0, void* memory, [NativeTypeName("nk_size")] ulong size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_info", ExactSpelling = true)]
    public static extern void buffer_info([NativeTypeName("struct nk_memory_status *")] NkMemoryStatus* param0, [NativeTypeName("struct nk_buffer *")] NkBuffer* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_push", ExactSpelling = true)]
    public static extern void buffer_push([NativeTypeName("struct nk_buffer *")] NkBuffer* param0, [NativeTypeName("enum nk_buffer_allocation_type")] NkBufferAllocationType type, [NativeTypeName("const void *")] void* memory, [NativeTypeName("nk_size")] ulong size, [NativeTypeName("nk_size")] ulong align);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_mark", ExactSpelling = true)]
    public static extern void buffer_mark([NativeTypeName("struct nk_buffer *")] NkBuffer* param0, [NativeTypeName("enum nk_buffer_allocation_type")] NkBufferAllocationType type);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_reset", ExactSpelling = true)]
    public static extern void buffer_reset([NativeTypeName("struct nk_buffer *")] NkBuffer* param0, [NativeTypeName("enum nk_buffer_allocation_type")] NkBufferAllocationType type);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_clear", ExactSpelling = true)]
    public static extern void buffer_clear([NativeTypeName("struct nk_buffer *")] NkBuffer* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_free", ExactSpelling = true)]
    public static extern void buffer_free([NativeTypeName("struct nk_buffer *")] NkBuffer* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_memory", ExactSpelling = true)]
    public static extern void* buffer_memory([NativeTypeName("struct nk_buffer *")] NkBuffer* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_memory_const", ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* buffer_memory_const([NativeTypeName("const struct nk_buffer *")] NkBuffer* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_buffer_total", ExactSpelling = true)]
    [return: NativeTypeName("nk_size")]
    public static extern ulong buffer_total([NativeTypeName("struct nk_buffer *")] NkBuffer* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_init", ExactSpelling = true)]
    public static extern void str_init([NativeTypeName("struct nk_str *")] NkStr* param0, [NativeTypeName("const struct nk_allocator *")] NkAllocator* param1, [NativeTypeName("nk_size")] ulong size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_init_fixed", ExactSpelling = true)]
    public static extern void str_init_fixed([NativeTypeName("struct nk_str *")] NkStr* param0, void* memory, [NativeTypeName("nk_size")] ulong size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_clear", ExactSpelling = true)]
    public static extern void str_clear([NativeTypeName("struct nk_str *")] NkStr* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_free", ExactSpelling = true)]
    public static extern void str_free([NativeTypeName("struct nk_str *")] NkStr* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_append_text_char", ExactSpelling = true)]
    public static extern int str_append_text_char([NativeTypeName("struct nk_str *")] NkStr* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_append_str_char", ExactSpelling = true)]
    public static extern int str_append_str_char([NativeTypeName("struct nk_str *")] NkStr* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_append_text_utf8", ExactSpelling = true)]
    public static extern int str_append_text_utf8([NativeTypeName("struct nk_str *")] NkStr* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_append_str_utf8", ExactSpelling = true)]
    public static extern int str_append_str_utf8([NativeTypeName("struct nk_str *")] NkStr* param0, [NativeTypeName("const char *")] sbyte* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_append_text_runes", ExactSpelling = true)]
    public static extern int str_append_text_runes([NativeTypeName("struct nk_str *")] NkStr* param0, [NativeTypeName("const nk_rune *")] uint* param1, int param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_append_str_runes", ExactSpelling = true)]
    public static extern int str_append_str_runes([NativeTypeName("struct nk_str *")] NkStr* param0, [NativeTypeName("const nk_rune *")] uint* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_insert_at_char", ExactSpelling = true)]
    public static extern int str_insert_at_char([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("const char *")] sbyte* param2, int param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_insert_at_rune", ExactSpelling = true)]
    public static extern int str_insert_at_rune([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("const char *")] sbyte* param2, int param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_insert_text_char", ExactSpelling = true)]
    public static extern int str_insert_text_char([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("const char *")] sbyte* param2, int param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_insert_str_char", ExactSpelling = true)]
    public static extern int str_insert_str_char([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("const char *")] sbyte* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_insert_text_utf8", ExactSpelling = true)]
    public static extern int str_insert_text_utf8([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("const char *")] sbyte* param2, int param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_insert_str_utf8", ExactSpelling = true)]
    public static extern int str_insert_str_utf8([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("const char *")] sbyte* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_insert_text_runes", ExactSpelling = true)]
    public static extern int str_insert_text_runes([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("const nk_rune *")] uint* param2, int param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_insert_str_runes", ExactSpelling = true)]
    public static extern int str_insert_str_runes([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("const nk_rune *")] uint* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_remove_chars", ExactSpelling = true)]
    public static extern void str_remove_chars([NativeTypeName("struct nk_str *")] NkStr* param0, int len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_remove_runes", ExactSpelling = true)]
    public static extern void str_remove_runes([NativeTypeName("struct nk_str *")] NkStr* str, int len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_delete_chars", ExactSpelling = true)]
    public static extern void str_delete_chars([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, int len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_delete_runes", ExactSpelling = true)]
    public static extern void str_delete_runes([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, int len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_at_char", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* str_at_char([NativeTypeName("struct nk_str *")] NkStr* param0, int pos);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_at_rune", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* str_at_rune([NativeTypeName("struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("nk_rune *")] uint* unicode, int* len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_rune_at", ExactSpelling = true)]
    [return: NativeTypeName("nk_rune")]
    public static extern uint str_rune_at([NativeTypeName("const struct nk_str *")] NkStr* param0, int pos);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_at_char_const", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* str_at_char_const([NativeTypeName("const struct nk_str *")] NkStr* param0, int pos);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_at_const", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* str_at_const([NativeTypeName("const struct nk_str *")] NkStr* param0, int pos, [NativeTypeName("nk_rune *")] uint* unicode, int* len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_get", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* str_get([NativeTypeName("struct nk_str *")] NkStr* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_get_const", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* str_get_const([NativeTypeName("const struct nk_str *")] NkStr* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_len", ExactSpelling = true)]
    public static extern int str_len([NativeTypeName("struct nk_str *")] NkStr* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_str_len_char", ExactSpelling = true)]
    public static extern int str_len_char([NativeTypeName("struct nk_str *")] NkStr* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_filter_default", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool filter_default([NativeTypeName("const struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("nk_rune")] uint unicode);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_filter_ascii", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool filter_ascii([NativeTypeName("const struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("nk_rune")] uint unicode);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_filter_float", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool filter_float([NativeTypeName("const struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("nk_rune")] uint unicode);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_filter_decimal", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool filter_decimal([NativeTypeName("const struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("nk_rune")] uint unicode);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_filter_hex", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool filter_hex([NativeTypeName("const struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("nk_rune")] uint unicode);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_filter_oct", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool filter_oct([NativeTypeName("const struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("nk_rune")] uint unicode);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_filter_binary", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool filter_binary([NativeTypeName("const struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("nk_rune")] uint unicode);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_init", ExactSpelling = true)]
    public static extern void textedit_init([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("struct nk_allocator *")] NkAllocator* param1, [NativeTypeName("nk_size")] ulong size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_init_fixed", ExactSpelling = true)]
    public static extern void textedit_init_fixed([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0, void* memory, [NativeTypeName("nk_size")] ulong size);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_free", ExactSpelling = true)]
    public static extern void textedit_free([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_text", ExactSpelling = true)]
    public static extern void textedit_text([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("const char *")] sbyte* param1, int TotalLen);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_delete", ExactSpelling = true)]
    public static extern void textedit_delete([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0, int where, int len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_delete_selection", ExactSpelling = true)]
    public static extern void textedit_delete_selection([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_select_all", ExactSpelling = true)]
    public static extern void textedit_select_all([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_cut", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool textedit_cut([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_paste", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool textedit_paste([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0, [NativeTypeName("const char *")] sbyte* param1, int len);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_undo", ExactSpelling = true)]
    public static extern void textedit_undo([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_textedit_redo", ExactSpelling = true)]
    public static extern void textedit_redo([NativeTypeName("struct nk_text_edit *")] NkTextEdit* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stroke_line", ExactSpelling = true)]
    public static extern void stroke_line([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* b, float x0, float y0, float x1, float y1, float LineThickness, [NativeTypeName("struct nk_color")] NkColor param6);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stroke_curve", ExactSpelling = true)]
    public static extern void stroke_curve([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, float param1, float param2, float param3, float param4, float param5, float param6, float param7, float param8, float LineThickness, [NativeTypeName("struct nk_color")] NkColor param10);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stroke_rect", ExactSpelling = true)]
    public static extern void stroke_rect([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, float rounding, float LineThickness, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stroke_circle", ExactSpelling = true)]
    public static extern void stroke_circle([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, float LineThickness, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stroke_arc", ExactSpelling = true)]
    public static extern void stroke_arc([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, float cx, float cy, float radius, float AMin, float AMax, float LineThickness, [NativeTypeName("struct nk_color")] NkColor param7);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stroke_triangle", ExactSpelling = true)]
    public static extern void stroke_triangle([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, float param1, float param2, float param3, float param4, float param5, float param6, float LineThichness, [NativeTypeName("struct nk_color")] NkColor param8);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stroke_polyline", ExactSpelling = true)]
    public static extern void stroke_polyline([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, float* points, int PointCount, float LineThickness, [NativeTypeName("struct nk_color")] NkColor col);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_stroke_polygon", ExactSpelling = true)]
    public static extern void stroke_polygon([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, float* param1, int PointCount, float LineThickness, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_fill_rect", ExactSpelling = true)]
    public static extern void fill_rect([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, float rounding, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_fill_rect_multi_color", ExactSpelling = true)]
    public static extern void fill_rect_multi_color([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, [NativeTypeName("struct nk_color")] NkColor left, [NativeTypeName("struct nk_color")] NkColor top, [NativeTypeName("struct nk_color")] NkColor right, [NativeTypeName("struct nk_color")] NkColor bottom);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_fill_circle", ExactSpelling = true)]
    public static extern void fill_circle([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, [NativeTypeName("struct nk_color")] NkColor param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_fill_arc", ExactSpelling = true)]
    public static extern void fill_arc([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, float cx, float cy, float radius, float AMin, float AMax, [NativeTypeName("struct nk_color")] NkColor param6);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_fill_triangle", ExactSpelling = true)]
    public static extern void fill_triangle([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, float x0, float y0, float x1, float y1, float x2, float y2, [NativeTypeName("struct nk_color")] NkColor param7);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_fill_polygon", ExactSpelling = true)]
    public static extern void fill_polygon([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, float* param1, int PointCount, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_image", ExactSpelling = true)]
    public static extern void draw_image([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, [NativeTypeName("const struct nk_image *")] NkImage* param2, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_nine_slice", ExactSpelling = true)]
    public static extern void draw_nine_slice([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, [NativeTypeName("const struct nk_nine_slice *")] NkNineSlice* param2, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_text", ExactSpelling = true)]
    public static extern void draw_text([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, [NativeTypeName("const char *")] sbyte* text, int len, [NativeTypeName("const struct nk_user_font *")] NkUserFont* param4, [NativeTypeName("struct nk_color")] NkColor param5, [NativeTypeName("struct nk_color")] NkColor param6);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_push_scissor", ExactSpelling = true)]
    public static extern void push_scissor([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_push_custom", ExactSpelling = true)]
    public static extern void push_custom([NativeTypeName("struct nk_command_buffer *")] NkCommandBuffer* param0, [NativeTypeName("struct nk_rect")] NkRect param1, [NativeTypeName("nk_command_custom_callback")] delegate* unmanaged[Cdecl]<void*, short, short, ushort, ushort, NkHandle, void> param2, NkHandle usr);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_has_mouse_click", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_has_mouse_click([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_has_mouse_click_in_rect", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_has_mouse_click_in_rect([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1, [NativeTypeName("struct nk_rect")] NkRect param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_has_mouse_click_in_button_rect", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_has_mouse_click_in_button_rect([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1, [NativeTypeName("struct nk_rect")] NkRect param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_has_mouse_click_down_in_rect", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_has_mouse_click_down_in_rect([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1, [NativeTypeName("struct nk_rect")] NkRect param2, [NativeTypeName("nk_bool")] bool down);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_mouse_click_in_rect", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_mouse_click_in_rect([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1, [NativeTypeName("struct nk_rect")] NkRect param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_mouse_click_down_in_rect", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_mouse_click_down_in_rect([NativeTypeName("const struct nk_input *")] NkInput* i, [NativeTypeName("enum nk_buttons")] NkButtons id, [NativeTypeName("struct nk_rect")] NkRect b, [NativeTypeName("nk_bool")] bool down);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_any_mouse_click_in_rect", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_any_mouse_click_in_rect([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("struct nk_rect")] NkRect param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_mouse_prev_hovering_rect", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_mouse_prev_hovering_rect([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("struct nk_rect")] NkRect param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_mouse_hovering_rect", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_mouse_hovering_rect([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("struct nk_rect")] NkRect param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_mouse_clicked", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_mouse_clicked([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1, [NativeTypeName("struct nk_rect")] NkRect param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_mouse_down", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_mouse_down([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_mouse_pressed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_mouse_pressed([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_mouse_released", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_mouse_released([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_buttons")] NkButtons param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_key_pressed", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_key_pressed([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_keys")] NkKeys param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_key_released", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_key_released([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_keys")] NkKeys param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_input_is_key_down", ExactSpelling = true)]
    [return: NativeTypeName("nk_bool")]
    public static extern bool input_is_key_down([NativeTypeName("const struct nk_input *")] NkInput* param0, [NativeTypeName("enum nk_keys")] NkKeys param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_init", ExactSpelling = true)]
    public static extern void draw_list_init([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_setup", ExactSpelling = true)]
    public static extern void draw_list_setup([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("const struct nk_convert_config *")] NkConvertConfig* param1, [NativeTypeName("struct nk_buffer *")] NkBuffer* cmds, [NativeTypeName("struct nk_buffer *")] NkBuffer* vertices, [NativeTypeName("struct nk_buffer *")] NkBuffer* elements, [NativeTypeName("enum nk_anti_aliasing")] NkAntiAliasing LineAa, [NativeTypeName("enum nk_anti_aliasing")] NkAntiAliasing ShapeAa);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk__draw_list_begin", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_draw_command *")]
    public static extern NkDrawCommand* _draw_list_begin([NativeTypeName("const struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("const struct nk_buffer *")] NkBuffer* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk__draw_list_next", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_draw_command *")]
    public static extern NkDrawCommand* _draw_list_next([NativeTypeName("const struct nk_draw_command *")] NkDrawCommand* param0, [NativeTypeName("const struct nk_buffer *")] NkBuffer* param1, [NativeTypeName("const struct nk_draw_list *")] NkDrawList* param2);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk__draw_list_end", ExactSpelling = true)]
    [return: NativeTypeName("const struct nk_draw_command *")]
    public static extern NkDrawCommand* _draw_list_end([NativeTypeName("const struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("const struct nk_buffer *")] NkBuffer* param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_path_clear", ExactSpelling = true)]
    public static extern void draw_list_path_clear([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_path_line_to", ExactSpelling = true)]
    public static extern void draw_list_path_line_to([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 pos);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_path_arc_to_fast", ExactSpelling = true)]
    public static extern void draw_list_path_arc_to_fast([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 center, float radius, int AMin, int AMax);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_path_arc_to", ExactSpelling = true)]
    public static extern void draw_list_path_arc_to([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 center, float radius, float AMin, float AMax, [NativeTypeName("unsigned int")] uint segments);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_path_rect_to", ExactSpelling = true)]
    public static extern void draw_list_path_rect_to([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 a, [NativeTypeName("struct nk_vec2")] NkVec2 b, float rounding);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_path_curve_to", ExactSpelling = true)]
    public static extern void draw_list_path_curve_to([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 p2, [NativeTypeName("struct nk_vec2")] NkVec2 p3, [NativeTypeName("struct nk_vec2")] NkVec2 p4, [NativeTypeName("unsigned int")] uint NumSegments);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_path_fill", ExactSpelling = true)]
    public static extern void draw_list_path_fill([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_color")] NkColor param1);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_path_stroke", ExactSpelling = true)]
    public static extern void draw_list_path_stroke([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_color")] NkColor param1, [NativeTypeName("enum nk_draw_list_stroke")] NkDrawListStroke closed, float thickness);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_stroke_line", ExactSpelling = true)]
    public static extern void draw_list_stroke_line([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 a, [NativeTypeName("struct nk_vec2")] NkVec2 b, [NativeTypeName("struct nk_color")] NkColor param3, float thickness);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_stroke_rect", ExactSpelling = true)]
    public static extern void draw_list_stroke_rect([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_rect")] NkRect rect, [NativeTypeName("struct nk_color")] NkColor param2, float rounding, float thickness);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_stroke_triangle", ExactSpelling = true)]
    public static extern void draw_list_stroke_triangle([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 a, [NativeTypeName("struct nk_vec2")] NkVec2 b, [NativeTypeName("struct nk_vec2")] NkVec2 c, [NativeTypeName("struct nk_color")] NkColor param4, float thickness);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_stroke_circle", ExactSpelling = true)]
    public static extern void draw_list_stroke_circle([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 center, float radius, [NativeTypeName("struct nk_color")] NkColor param3, [NativeTypeName("unsigned int")] uint segs, float thickness);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_stroke_curve", ExactSpelling = true)]
    public static extern void draw_list_stroke_curve([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 p0, [NativeTypeName("struct nk_vec2")] NkVec2 cp0, [NativeTypeName("struct nk_vec2")] NkVec2 cp1, [NativeTypeName("struct nk_vec2")] NkVec2 p1, [NativeTypeName("struct nk_color")] NkColor param5, [NativeTypeName("unsigned int")] uint segments, float thickness);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_stroke_poly_line", ExactSpelling = true)]
    public static extern void draw_list_stroke_poly_line([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("const struct nk_vec2 *")] NkVec2* pnts, [NativeTypeName("const unsigned int")] uint cnt, [NativeTypeName("struct nk_color")] NkColor param3, [NativeTypeName("enum nk_draw_list_stroke")] NkDrawListStroke param4, float thickness, [NativeTypeName("enum nk_anti_aliasing")] NkAntiAliasing param6);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_fill_rect", ExactSpelling = true)]
    public static extern void draw_list_fill_rect([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_rect")] NkRect rect, [NativeTypeName("struct nk_color")] NkColor param2, float rounding);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_fill_rect_multi_color", ExactSpelling = true)]
    public static extern void draw_list_fill_rect_multi_color([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_rect")] NkRect rect, [NativeTypeName("struct nk_color")] NkColor left, [NativeTypeName("struct nk_color")] NkColor top, [NativeTypeName("struct nk_color")] NkColor right, [NativeTypeName("struct nk_color")] NkColor bottom);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_fill_triangle", ExactSpelling = true)]
    public static extern void draw_list_fill_triangle([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 a, [NativeTypeName("struct nk_vec2")] NkVec2 b, [NativeTypeName("struct nk_vec2")] NkVec2 c, [NativeTypeName("struct nk_color")] NkColor param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_fill_circle", ExactSpelling = true)]
    public static extern void draw_list_fill_circle([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_vec2")] NkVec2 center, float radius, [NativeTypeName("struct nk_color")] NkColor col, [NativeTypeName("unsigned int")] uint segs);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_fill_poly_convex", ExactSpelling = true)]
    public static extern void draw_list_fill_poly_convex([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("const struct nk_vec2 *")] NkVec2* points, [NativeTypeName("const unsigned int")] uint count, [NativeTypeName("struct nk_color")] NkColor param3, [NativeTypeName("enum nk_anti_aliasing")] NkAntiAliasing param4);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_add_image", ExactSpelling = true)]
    public static extern void draw_list_add_image([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("struct nk_image")] NkImage texture, [NativeTypeName("struct nk_rect")] NkRect rect, [NativeTypeName("struct nk_color")] NkColor param3);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_add_text", ExactSpelling = true)]
    public static extern void draw_list_add_text([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, [NativeTypeName("const struct nk_user_font *")] NkUserFont* param1, [NativeTypeName("struct nk_rect")] NkRect param2, [NativeTypeName("const char *")] sbyte* text, int len, float FontHeight, [NativeTypeName("struct nk_color")] NkColor param6);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_draw_list_push_userdata", ExactSpelling = true)]
    public static extern void draw_list_push_userdata([NativeTypeName("struct nk_draw_list *")] NkDrawList* param0, NkHandle userdata);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_item_color", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_style_item")]
    public static extern NkStyleItem style_item_color([NativeTypeName("struct nk_color")] NkColor param0);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_item_image", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_style_item")]
    public static extern NkStyleItem style_item_image([NativeTypeName("struct nk_image")] NkImage img);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_item_nine_slice", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_style_item")]
    public static extern NkStyleItem style_item_nine_slice([NativeTypeName("struct nk_nine_slice")] NkNineSlice slice);

    [DllImport("Nuklear", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nk_style_item_hide", ExactSpelling = true)]
    [return: NativeTypeName("struct nk_style_item")]
    public static extern NkStyleItem style_item_hide();

    [NativeTypeName("#define NK_UNDEFINED (-1.0f)")]
    public const float Undefined = (-1.0f);
}
