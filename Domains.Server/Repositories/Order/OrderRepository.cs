public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(DbContext dbContext) : base(dbContext)
    {
    }
}