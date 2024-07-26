using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public unsafe partial struct NkDrawList
{
    [NativeTypeName("struct nk_rect")]
    public NkRect ClipRect;

    [NativeTypeName("struct nk_vec2[12]")]
    public CircleVtxEFixedBuffer CircleVtx;

    [NativeTypeName("struct nk_convert_config")]
    public NkConvertConfig Config;

    [NativeTypeName("struct nk_buffer *")]
    public NkBuffer* Buffer;

    [NativeTypeName("struct nk_buffer *")]
    public NkBuffer* Vertices;

    [NativeTypeName("struct nk_buffer *")]
    public NkBuffer* Elements;

    [NativeTypeName("unsigned int")]
    public uint ElementCount;

    [NativeTypeName("unsigned int")]
    public uint VertexCount;

    [NativeTypeName("unsigned int")]
    public uint CmdCount;

    [NativeTypeName("nk_size")]
    public ulong CmdOffset;

    [NativeTypeName("unsigned int")]
    public uint PathCount;

    [NativeTypeName("unsigned int")]
    public uint PathOffset;

    [NativeTypeName("enum nk_anti_aliasing")]
    public NkAntiAliasing LineAa;

    [NativeTypeName("enum nk_anti_aliasing")]
    public NkAntiAliasing ShapeAa;

    public NkHandle Userdata;

    [InlineArray(12)]
    public partial struct CircleVtxEFixedBuffer
    {
        public NkVec2 E0;
    }
}
