public class CustomerConfigurations : BaseEntityConfiguration<Customer>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        base.Configure(builder);
        builder.Property(c => c.CustomerId).ValueGeneratedOnAdd();
        builder.Property(c => c.CustomerName).IsRequired().HasMaxLength(50);
        builder.Property(c => c.Email).IsRequired().HasMaxLength(50);
    }
}