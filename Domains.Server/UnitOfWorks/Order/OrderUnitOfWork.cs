public class OrderUnitOfWork : BaseUnitOfWork<Order>, IOrderUnitOfWork
{
    public OrderUnitOfWork(IOrderRepository repsitory) : base(repsitory)
    {
    }
}