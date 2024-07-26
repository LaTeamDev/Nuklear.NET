namespace Nuklear.NET;

public partial struct NkStyleItem
{
    [NativeTypeName("enum nk_style_item_type")]
    public NkStyleItemType Type;

    [NativeTypeName("union nk_style_item_data")]
    public NkStyleItemData Data;
}
