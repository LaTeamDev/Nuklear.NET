using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nuklear.NET;

public unsafe partial struct StbrpContext
{
    public int Width;

    public int Height;

    public int Align;

    public int InitMode;

    public int Heuristic;

    public int NumNodes;

    public StbrpNode* ActiveHead;

    public StbrpNode* FreeHead;

    [NativeTypeName("stbrp_node[2]")]
    public ExtraEFixedBuffer Extra;

    public partial struct ExtraEFixedBuffer
    {
        public StbrpNode E0;
        public StbrpNode E1;

        public ref StbrpNode this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<StbrpNode> AsSpan() => MemoryMarshal.CreateSpan(ref E0, 2);
    }
}
