namespace Nuklear.NET;

public unsafe partial struct StbttCsctx
{
    public int Bounds;

    public int Started;

    public float FirstX;

    public float FirstY;

    public float X;

    public float Y;

    [NativeTypeName("stbtt_int32")]
    public int MinX;

    [NativeTypeName("stbtt_int32")]
    public int MaxX;

    [NativeTypeName("stbtt_int32")]
    public int MinY;

    [NativeTypeName("stbtt_int32")]
    public int MaxY;

    public StbttVertex* Pvertices;

    public int NumVertices;
}
