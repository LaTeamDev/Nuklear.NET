using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public unsafe partial struct NkTable
{
    [NativeTypeName("unsigned int")]
    public uint Seq;

    [NativeTypeName("unsigned int")]
    public uint Size;

    [NativeTypeName("nk_hash[59]")]
    public KeysEFixedBuffer Keys;

    [NativeTypeName("nk_uint[59]")]
    public ValuesEFixedBuffer Values;

    [NativeTypeName("struct nk_table *")]
    public NkTable* Next;

    [NativeTypeName("struct nk_table *")]
    public NkTable* Prev;

    [InlineArray(59)]
    public partial struct KeysEFixedBuffer
    {
        public uint E0;
    }

    [InlineArray(59)]
    public partial struct ValuesEFixedBuffer
    {
        public uint E0;
    }
}
