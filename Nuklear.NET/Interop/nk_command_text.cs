using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nuklear.NET;

public unsafe partial struct NkCommandText
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    [NativeTypeName("const struct nk_user_font *")]
    public NkUserFont* Font;

    [NativeTypeName("struct nk_color")]
    public NkColor Background;

    [NativeTypeName("struct nk_color")]
    public NkColor Foreground;

    public short X;

    public short Y;

    [NativeTypeName("unsigned short")]
    public ushort W;

    [NativeTypeName("unsigned short")]
    public ushort H;

    public float Height;

    public int Length;

    [NativeTypeName("char[1]")]
    public StringEFixedBuffer String;

    public partial struct StringEFixedBuffer
    {
        public sbyte E0;

        [UnscopedRef]
        public ref sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref E0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref E0, length);
    }
}
