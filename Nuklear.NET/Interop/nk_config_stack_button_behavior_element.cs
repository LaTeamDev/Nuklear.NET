namespace Nuklear.NET;

public unsafe partial struct NkConfigStackButtonBehaviorElement
{
    [NativeTypeName("enum nk_button_behavior *")]
    public NkButtonBehavior* Address;

    [NativeTypeName("enum nk_button_behavior")]
    public NkButtonBehavior OldValue;
}
