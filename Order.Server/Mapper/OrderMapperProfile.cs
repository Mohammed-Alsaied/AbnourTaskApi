using Orders.Shared;

namespace Orders.Server;
public class OrderMapperProfile : Profile
{
    public OrderMapperProfile()
    {
        CreateMap<Order, OrderViewModel>().ReverseMap();
    }
}