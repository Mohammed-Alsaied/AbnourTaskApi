namespace Orders.Server;
using Common.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orders.Shared;
using System;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : BaseController<Order, OrderViewModel>
{
    //public CoachesController(ICoachUnitOfWork unitOfWork, IMapper mapper, IValidator<CoachViewModel> validator)
    //    : base(unitOfWork, mapper, validator)
    //{
    //}

    public OrdersController(IOrderUnitOfWork unitOfWork, IMapper mapper, IBaseValidation<OrderViewModel> validator)
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