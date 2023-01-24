namespace Sales.Server;
public class SalesUnitOfWork : BaseUnitOfWork<Sale>, ISalesUnitOfWork
{
    public SalesUnitOfWork(ISalesRepository repsitory) : base(repsitory)
    {
    }
}