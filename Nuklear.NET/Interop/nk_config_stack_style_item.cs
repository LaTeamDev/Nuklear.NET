using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkConfigStackStyleItem
{
    public int Head;

    [NativeTypeName("struct nk_config_stack_style_item_element[16]")]
    public ElementsEFixedBuffer Elements;

    [InlineArray(16)]
    public partial struct ElementsEFixedBuffer
    {
        public NkConfigStackStyleItemElement E0;
    }
}
