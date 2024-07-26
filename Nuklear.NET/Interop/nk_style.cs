using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public unsafe partial struct NkStyle
{
    [NativeTypeName("const struct nk_user_font *")]
    public NkUserFont* Font;

    [NativeTypeName("const struct nk_cursor *[7]")]
    public CursorsEFixedBuffer Cursors;

    [NativeTypeName("const struct nk_cursor *")]
    public NkCursor* CursorActive;

    [NativeTypeName("struct nk_cursor *")]
    public NkCursor* CursorLast;

    public int CursorVisible;

    [NativeTypeName("struct nk_style_text")]
    public NkStyleText Text;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton Button;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton ContextualButton;

    [NativeTypeName("struct nk_style_button")]
    public NkStyleButton MenuButton;

    [NativeTypeName("struct nk_style_toggle")]
    public NkStyleToggle Option;

    [NativeTypeName("struct nk_style_toggle")]
    public NkStyleToggle Checkbox;

    [NativeTypeName("struct nk_style_selectable")]
    public NkStyleSelectable Selectable;

    [NativeTypeName("struct nk_style_slider")]
    public NkStyleSlider Slider;

    [NativeTypeName("struct nk_style_progress")]
    public NkStyleProgress Progress;

    [NativeTypeName("struct nk_style_property")]
    public NkStyleProperty Property;

    [NativeTypeName("struct nk_style_edit")]
    public NkStyleEdit Edit;

    [NativeTypeName("struct nk_style_chart")]
    public NkStyleChart Chart;

    [NativeTypeName("struct nk_style_scrollbar")]
    public NkStyleScrollbar Scrollh;

    [NativeTypeName("struct nk_style_scrollbar")]
    public NkStyleScrollbar Scrollv;

    [NativeTypeName("struct nk_style_tab")]
    public NkStyleTab Tab;

    [NativeTypeName("struct nk_style_combo")]
    public NkStyleCombo Combo;

    [NativeTypeName("struct nk_style_window")]
    public NkStyleWindow Window;

    public unsafe partial struct CursorsEFixedBuffer
    {
        public NkCursor* E0;
        public NkCursor* E1;
        public NkCursor* E2;
        public NkCursor* E3;
        public NkCursor* E4;
        public NkCursor* E5;
        public NkCursor* E6;

        public ref NkCursor* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (NkCursor** pThis = &E0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
