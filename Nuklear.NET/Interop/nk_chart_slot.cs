namespace Nuklear.NET;

public partial struct NkChartSlot
{
    [NativeTypeName("enum nk_chart_type")]
    public NkChartType Type;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;

    [NativeTypeName("struct nk_color")]
    public NkColor Highlight;

    public float Min;

    public float Max;

    public float Range;

    public int Count;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Last;

    public int Index;
}
