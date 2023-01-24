using Common.AssemplyScanning;

public class OrderServiceInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<OrderViewModel>, OrderValidator>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderUnitOfWork, OrderUnitOfWork>();
    }
}
