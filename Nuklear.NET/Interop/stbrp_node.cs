namespace Nuklear.NET;

public unsafe partial struct StbrpNode
{
    [NativeTypeName("stbrp_coord")]
    public int X;

    [NativeTypeName("stbrp_coord")]
    public int Y;

    public StbrpNode* Next;
}
