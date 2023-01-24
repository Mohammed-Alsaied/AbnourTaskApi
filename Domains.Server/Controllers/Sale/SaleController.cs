[Route("api/[controller]")]
[ApiController]
public class SaleController : BaseController<Sale, SalesViewModel>
{
    public SaleController(ISalesUnitOfWork unitOfWork, IMapper mapper, IValidator<SalesViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }

    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] SalesViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Put(Guid id, [FromBody] SalesViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}