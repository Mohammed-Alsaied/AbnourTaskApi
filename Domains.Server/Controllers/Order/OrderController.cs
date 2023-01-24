[Route("api/[controller]")]
[ApiController]
public class OrderController : BaseController<Order, OrderViewModel>
{

    public OrderController(IOrderUnitOfWork unitOfWork, IMapper mapper, IValidator<OrderViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }


    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] OrderViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put(Guid id, [FromBody] OrderViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}