using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkConfigStackColor
{
    public int Head;

    [NativeTypeName("struct nk_config_stack_color_element[32]")]
    public ElementsEFixedBuffer Elements;

    [InlineArray(32)]
    public partial struct ElementsEFixedBuffer
    {
        public NkConfigStackColorElement E0;
    }
}
