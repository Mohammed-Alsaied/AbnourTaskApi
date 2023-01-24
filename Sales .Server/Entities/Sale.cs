namespace Sales.Server;
public class Sale : BaseEntity
{
    public string SalesName { get; set; }
    public string Email { get; set; }

    //public ICollection<Order> Orders { get; set; }
}