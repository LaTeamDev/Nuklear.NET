using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public partial struct NkChart
{
    public int Slot;

    public float X;

    public float Y;

    public float W;

    public float H;

    [NativeTypeName("struct nk_chart_slot[4]")]
    public SlotsEFixedBuffer Slots;

    [InlineArray(4)]
    public partial struct SlotsEFixedBuffer
    {
        public NkChartSlot E0;
    }
}
