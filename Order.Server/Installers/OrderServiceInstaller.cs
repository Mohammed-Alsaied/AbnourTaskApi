using Common.Configurations;
using Orders.Server;
using Orders.Shared;
using Orders.Shared.Validators;

namespace Customers.Server;
public class OrderServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<OrderViewModel>, OrderValidator>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderUnitOfWork, OrderUnitOfWork>();
    }
}
