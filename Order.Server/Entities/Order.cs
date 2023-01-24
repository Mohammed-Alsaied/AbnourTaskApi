namespace Orders.Server;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; }
    //public Customer Customers { get; set; }

    public Guid SalesId { get; set; }
    //public Sale Sales { get; set; }


}