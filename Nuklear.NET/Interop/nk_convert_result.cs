namespace Nuklear.NET;

public enum NkConvertResult
{
    Success = 0,
    InvalidParam = 1,
    CommandBufferFull = (1 << (1)),
    VertexBufferFull = (1 << (2)),
    ElementBufferFull = (1 << (3)),
}
