using Sales.Shared;
namespace Sales.Server;
public class SalesMapperProfile : Profile
{
    public SalesMapperProfile()
    {
        CreateMap<Sale, SalesViewModel>().ReverseMap();
    }
}