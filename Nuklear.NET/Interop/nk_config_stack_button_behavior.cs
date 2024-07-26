using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkConfigStackButtonBehavior
{
    public int Head;

    [NativeTypeName("struct nk_config_stack_button_behavior_element[8]")]
    public ElementsEFixedBuffer Elements;

    [InlineArray(8)]
    public partial struct ElementsEFixedBuffer
    {
        public NkConfigStackButtonBehaviorElement E0;
    }
}
