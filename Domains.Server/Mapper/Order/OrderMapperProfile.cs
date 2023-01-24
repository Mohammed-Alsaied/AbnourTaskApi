public class OrderMapperProfile : Profile
{
    public OrderMapperProfile()
    {
        CreateMap<Order, OrderViewModel>().ReverseMap();
    }
}