public class SalesMapperProfile : Profile
{
    public SalesMapperProfile()
    {
        CreateMap<Sale, SalesViewModel>().ReverseMap();
    }
}