namespace Nuklear.NET;

public unsafe partial struct StbttActiveEdge
{
    [NativeTypeName("struct stbtt__active_edge *")]
    public StbttActiveEdge* Next;

    public float Fx;

    public float Fdx;

    public float Fdy;

    public float Direction;

    public float Sy;

    public float Ey;
}
