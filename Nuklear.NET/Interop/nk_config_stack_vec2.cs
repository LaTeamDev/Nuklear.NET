using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkConfigStackVec2
{
    public int Head;

    [NativeTypeName("struct nk_config_stack_vec2_element[16]")]
    public ElementsEFixedBuffer Elements;

    [InlineArray(16)]
    public partial struct ElementsEFixedBuffer
    {
        public NkConfigStackVec2Element E0;
    }
}
