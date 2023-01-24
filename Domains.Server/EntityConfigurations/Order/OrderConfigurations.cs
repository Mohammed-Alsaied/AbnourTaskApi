public class OrderConfigurations : BaseEntityConfiguration<Order>
{
    public override void Configure(EntityTypeBuilder<Order> builder)
    {
        base.Configure(builder);
        builder.Property(o => o.OrderDate).HasDefaultValueSql("GETDATE()");
    }
}