namespace Nuklear.NET;

public unsafe partial struct NkConfigStackVec2Element
{
    [NativeTypeName("struct nk_vec2 *")]
    public NkVec2* Address;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 OldValue;
}
