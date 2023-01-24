public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(DbContext dbContext) : base(dbContext)
    {
    }
}