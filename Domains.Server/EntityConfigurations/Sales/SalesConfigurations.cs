public class SalesConfigurations : BaseEntityConfiguration<Sale>
{
    public override void Configure(EntityTypeBuilder<Sale> builder)
    {
        base.Configure(builder);
        builder.Property(c => c.SaleId).ValueGeneratedOnAdd();
        builder.Property(c => c.SalesName).IsRequired();
        builder.Property(c => c.Email).IsRequired();
    }
}