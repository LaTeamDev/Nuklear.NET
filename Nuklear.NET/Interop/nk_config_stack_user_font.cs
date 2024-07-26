using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkConfigStackUserFont
{
    public int Head;

    [NativeTypeName("struct nk_config_stack_user_font_element[8]")]
    public ElementsEFixedBuffer Elements;

    [InlineArray(8)]
    public partial struct ElementsEFixedBuffer
    {
        public NkConfigStackUserFontElement E0;
    }
}
