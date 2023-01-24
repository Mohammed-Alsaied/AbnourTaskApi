public class OrderViewModel : BaseViewModel
{
    public Guid? CustomerId { get; set; }
    public Guid? SalesId { get; set; }
    public DateTime OrderDate { get; set; }
}