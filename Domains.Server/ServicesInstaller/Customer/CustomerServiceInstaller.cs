using Common.AssemplyScanning;
public class CustomerServiceInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<CustomerViewModel>, CustomerValidator>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICustomerUnitOfWork, CustomerUnitOfWork>();
    }
}
