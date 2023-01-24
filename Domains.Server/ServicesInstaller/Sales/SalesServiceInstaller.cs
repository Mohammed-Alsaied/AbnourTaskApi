using Common.AssemplyScanning;
public class SalesServiceInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<SalesViewModel>, SalesValidator>();
        services.AddScoped<ISalesRepository, SalesRepository>();
        services.AddScoped<ISalesUnitOfWork, SalesUnitOfWork>();
    }
}
