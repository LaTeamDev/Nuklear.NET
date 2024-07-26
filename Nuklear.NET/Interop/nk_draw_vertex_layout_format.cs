namespace Nuklear.NET;

public enum NkDrawVertexLayoutFormat
{
    Schar,
    Sshort,
    Sint,
    Uchar,
    Ushort,
    Uint,
    Float,
    Double,
    ColorBegin,
    R8G8B8 = ColorBegin,
    R16G15B16,
    R32G32B32,
    R8G8B8A8,
    B8G8R8A8,
    R16G15B16A16,
    R32G32B32A32,
    R32G32B32A32Float,
    R32G32B32A32Double,
    Rgb32,
    Rgba32,
    ColorEnd = Rgba32,
    Count,
}
