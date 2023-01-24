namespace Sales.Server;
public class SalesConfigurations : BaseEntityConfiguration<Sale>
{
    public override void Configure(EntityTypeBuilder<Sale> builder)
    {
        base.Configure(builder);
        builder.Property(c => c.Email).IsRequired();
    }
}