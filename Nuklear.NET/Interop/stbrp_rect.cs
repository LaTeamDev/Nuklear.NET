namespace Nuklear.NET;

public partial struct StbrpRect
{
    public int Id;

    [NativeTypeName("stbrp_coord")]
    public int W;

    [NativeTypeName("stbrp_coord")]
    public int H;

    [NativeTypeName("stbrp_coord")]
    public int X;

    [NativeTypeName("stbrp_coord")]
    public int Y;

    public int WasPacked;
}
