public class Sale : BaseEntity
{
    public Guid SaleId { get; set; }

    public string SalesName { get; set; }
    public string Email { get; set; }
    public List<Order> Order { get; set; }
}