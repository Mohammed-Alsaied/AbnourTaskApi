public class CustomerUnitOfWork : BaseUnitOfWork<Customer>, ICustomerUnitOfWork
{
    public CustomerUnitOfWork(ICustomerRepository repsitory) : base(repsitory)
    {
    }
}