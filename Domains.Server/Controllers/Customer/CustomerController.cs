[Route("api/[controller]")]
[ApiController]
public class CustomerController : BaseController<Customer, CustomerViewModel>
{
    public CustomerController(ICustomerUnitOfWork unitOfWork, IMapper mapper, IValidator<CustomerViewModel> validator)
        : base(unitOfWork, mapper, validator)
    {
    }

    /// <summary>
    /// Delete Customer By Id
    /// </summary>
    /// <param name="id">Id for Customer</param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    public override Task Delete(Guid id)
    {
        return base.Delete(id);
    }

    [Authorize(Roles = "Admin")]
    public override Task<IActionResult> Post([FromBody] CustomerViewModel productViewModel)
    {
        return base.Post(productViewModel);
    }
    [Authorize(Roles = "Admin")]
    //public override Task<IActionResult> Put([FromBody] CustomerViewModel productViewModel)
    //{
    //    return base.Put(productViewModel);
    //}
    public override Task<IActionResult> Put(Guid id, [FromBody] CustomerViewModel productViewModel)
    {
        return base.Put(id, productViewModel);
    }
}