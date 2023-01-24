public class Order : BaseEntity
{
    public DateTime OrderDate { get; set; }
    public Guid? CustomerId { get; set; }
    public Customer Customer { get; set; }
    public Guid? SalesId { get; set; }
    public Sale Sale { get; set; }
}