using Common.Configurations;
using Sales.Server;
using Sales.Shared;
using Sales.Shared.Validators;

namespace Customers.Server;
public class SalesServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<SalesViewModel>, SalesValidator>();
        services.AddScoped<ISalesRepository, SalesRepository>();
        services.AddScoped<ISalesUnitOfWork, SalesUnitOfWork>();
    }
}
