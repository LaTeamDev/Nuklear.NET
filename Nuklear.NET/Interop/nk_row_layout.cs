using System.Runtime.CompilerServices;

namespace Nuklear.NET;

public unsafe partial struct NkRowLayout
{
    [NativeTypeName("enum nk_panel_row_layout_type")]
    public NkPanelRowLayoutType Type;

    public int Index;

    public float Height;

    public float MinHeight;

    public int Columns;

    [NativeTypeName("const float *")]
    public float* Ratio;

    public float ItemWidth;

    public float ItemHeight;

    public float ItemOffset;

    public float Filled;

    [NativeTypeName("struct nk_rect")]
    public NkRect Item;

    public int TreeDepth;

    [NativeTypeName("float[16]")]
    public TemplatesEFixedBuffer Templates;

    [InlineArray(16)]
    public partial struct TemplatesEFixedBuffer
    {
        public float E0;
    }
}
