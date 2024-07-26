namespace Nuklear.NET;

public unsafe partial struct NkConfigStackUserFontElement
{
    [NativeTypeName("const struct nk_user_font **")]
    public NkUserFont** Address;

    [NativeTypeName("const struct nk_user_font *")]
    public NkUserFont* OldValue;
}
