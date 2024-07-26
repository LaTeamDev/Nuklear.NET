using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkKeyboard
{
    [NativeTypeName("struct nk_key[30]")]
    public KeysEFixedBuffer Keys;

    [NativeTypeName("char[512]")]
    public TextEFixedBuffer Text;

    public int TextLen;

    [InlineArray(30)]
    public partial struct KeysEFixedBuffer
    {
        public NkKey E0;
    }

    [InlineArray(512)]
    public partial struct TextEFixedBuffer
    {
        public sbyte E0;
    }
}
