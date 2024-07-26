namespace Nuklear.NET;

public partial struct PropertyVariant
{
    [NativeTypeName("enum nk_property_kind")]
    public PropertyKind Kind;

    [NativeTypeName("union nk_property")]
    public Property Value;

    [NativeTypeName("union nk_property")]
    public Property MinValue;

    [NativeTypeName("union nk_property")]
    public Property MaxValue;

    [NativeTypeName("union nk_property")]
    public Property Step;
}
