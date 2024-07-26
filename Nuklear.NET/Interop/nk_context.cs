namespace Nuklear.NET;

public unsafe partial struct NkContext
{
    [NativeTypeName("struct nk_input")]
    public NkInput Input;

    [NativeTypeName("struct nk_style")]
    public NkStyle Style;

    [NativeTypeName("struct nk_buffer")]
    public NkBuffer Memory;

    [NativeTypeName("struct nk_clipboard")]
    public NkClipboard Clip;

    [NativeTypeName("nk_flags")]
    public uint LastWidgetState;

    [NativeTypeName("enum nk_button_behavior")]
    public NkButtonBehavior ButtonBehavior;

    [NativeTypeName("struct nk_configuration_stacks")]
    public NkConfigurationStacks Stacks;

    public float DeltaTimeSeconds;

    [NativeTypeName("struct nk_draw_list")]
    public NkDrawList DrawList;

    public NkHandle Userdata;

    [NativeTypeName("struct nk_text_edit")]
    public NkTextEdit TextEdit;

    [NativeTypeName("struct nk_command_buffer")]
    public NkCommandBuffer Overlay;

    public int Build;

    public int UsePool;

    [NativeTypeName("struct nk_pool")]
    public NkPool Pool;

    [NativeTypeName("struct nk_window *")]
    public NkWindow* Begin;

    [NativeTypeName("struct nk_window *")]
    public NkWindow* End;

    [NativeTypeName("struct nk_window *")]
    public NkWindow* Active;

    [NativeTypeName("struct nk_window *")]
    public NkWindow* Current;

    [NativeTypeName("struct nk_page_element *")]
    public NkPageElement* Freelist;

    [NativeTypeName("unsigned int")]
    public uint Count;

    [NativeTypeName("unsigned int")]
    public uint Seq;
}
