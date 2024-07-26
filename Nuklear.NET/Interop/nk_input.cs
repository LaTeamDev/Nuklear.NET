namespace Nuklear.NET;

public partial struct NkInput
{
    [NativeTypeName("struct nk_keyboard")]
    public NkKeyboard Keyboard;

    [NativeTypeName("struct nk_mouse")]
    public NkMouse Mouse;
}
