namespace Nuklear.NET;

public partial struct NkConfigurationStacks
{
    [NativeTypeName("struct nk_config_stack_style_item")]
    public NkConfigStackStyleItem StyleItems;

    [NativeTypeName("struct nk_config_stack_float")]
    public NkConfigStackFloat Floats;

    [NativeTypeName("struct nk_config_stack_vec2")]
    public NkConfigStackVec2 Vectors;

    [NativeTypeName("struct nk_config_stack_flags")]
    public NkConfigStackFlags Flags;

    [NativeTypeName("struct nk_config_stack_color")]
    public NkConfigStackColor Colors;

    [NativeTypeName("struct nk_config_stack_user_font")]
    public NkConfigStackUserFont Fonts;

    [NativeTypeName("struct nk_config_stack_button_behavior")]
    public NkConfigStackButtonBehavior ButtonBehaviors;
}
