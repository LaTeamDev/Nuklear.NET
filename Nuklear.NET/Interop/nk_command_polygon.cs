using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nuklear.NET;

public partial struct NkCommandPolygon
{
    [NativeTypeName("struct nk_command")]
    public NkCommand Header;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;

    [NativeTypeName("unsigned short")]
    public ushort LineThickness;

    [NativeTypeName("unsigned short")]
    public ushort PointCount;

    [NativeTypeName("struct nk_vec2i[1]")]
    public PointsEFixedBuffer Points;

    public partial struct PointsEFixedBuffer
    {
        public NkVec2I E0;

        [UnscopedRef]
        public ref NkVec2I this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref E0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<NkVec2I> AsSpan(int length) => MemoryMarshal.CreateSpan(ref E0, length);
    }
}
