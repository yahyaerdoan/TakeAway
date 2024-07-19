using MediatR;
using Microsoft.AspNetCore.Mvc;
using TakeAway.ApplicationLayer.Features.Mediator.Commands.OrderCommands;
using TakeAway.ApplicationLayer.Features.Mediator.Queries.OrderQueries;

namespace TakeAway.OrderPresentationLayer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var values = await _mediator.Send(new GetOrderQuery());
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var values = await _mediator.Send(new GetOrderByIdQuery(id));
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderCommand createOrderCommand)
    {
        await _mediator.Send(createOrderCommand);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> Update(UpdateOrderCommand updateOrderCommand)
    {
        await _mediator.Send(updateOrderCommand);
        return Ok();
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
        await _mediator.Send(new DeleteOrderCommand(id));
        return Ok();
    }
}
