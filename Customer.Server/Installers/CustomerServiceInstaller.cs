using Common.Configurations;
using Customers.Shared.Validators;

namespace Customers.Server;
public class CustomerServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<CustomerViewModel>, CustomerValidator>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICustomerUnitOfWork, CustomerUnitOfWork>();
    }
}
