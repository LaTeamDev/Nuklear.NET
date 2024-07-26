namespace Nuklear.NET;

public partial struct NkStyleChart
{
    [NativeTypeName("struct nk_style_item")]
    public NkStyleItem Background;

    [NativeTypeName("struct nk_color")]
    public NkColor BorderColor;

    [NativeTypeName("struct nk_color")]
    public NkColor SelectedColor;

    [NativeTypeName("struct nk_color")]
    public NkColor Color;

    public float Border;

    public float Rounding;

    [NativeTypeName("struct nk_vec2")]
    public NkVec2 Padding;
}
