namespace Sales.Server;
public class SalesRepository : BaseRepository<Sale>, ISalesRepository
{
    public SalesRepository(DbContext dbContext) : base(dbContext)
    {
    }
}