namespace Orders.Server;
public class OrderConfigurations : BaseEntityConfiguration<Order>
{
    public override void Configure(EntityTypeBuilder<Order> builder)
    {
        base.Configure(builder);
        builder.Property(c => c.CustomerId).ValueGeneratedOnAdd();
        //builder.Property(c => c.).IsRequired().HasMaxLength(50);
    }
}