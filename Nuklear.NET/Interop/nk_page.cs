using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nuklear.NET;

public unsafe partial struct NkPage
{
    [NativeTypeName("unsigned int")]
    public uint Size;

    [NativeTypeName("struct nk_page *")]
    public NkPage* Next;

    [NativeTypeName("struct nk_page_element[1]")]
    public WinEFixedBuffer Win;

    public partial struct WinEFixedBuffer
    {
        public NkPageElement E0;

        [UnscopedRef]
        public ref NkPageElement this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref E0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<NkPageElement> AsSpan(int length) => MemoryMarshal.CreateSpan(ref E0, length);
    }
}
