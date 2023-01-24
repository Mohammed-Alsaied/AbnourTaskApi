public class CustomerMapperProfile : Profile
{
    public CustomerMapperProfile()
    {
        CreateMap<Customer, CustomerViewModel>().ReverseMap();
    }
}