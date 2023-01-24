public class Customer : BaseEntity
{
    public Guid CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Email { get; set; }
    public List<Order> Order { get; set; }
}