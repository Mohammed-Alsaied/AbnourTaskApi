namespace Customers.Server;
public class Customer : BaseEntity
{
    public string CustomerName { get; set; }
    public string Email { get; set; }
    public List<CustomerOrder> Customers { get; set; }
}