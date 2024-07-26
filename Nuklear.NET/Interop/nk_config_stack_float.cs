using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkConfigStackFloat
{
    public int Head;

    [NativeTypeName("struct nk_config_stack_float_element[32]")]
    public ElementsEFixedBuffer Elements;

    [InlineArray(32)]
    public partial struct ElementsEFixedBuffer
    {
        public NkConfigStackFloatElement E0;
    }
}
