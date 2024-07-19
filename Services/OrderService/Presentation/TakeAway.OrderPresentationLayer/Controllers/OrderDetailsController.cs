using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.ApplicationLayer.Features.CQRS.Commands.OrderDetailCommands;
using TakeAway.ApplicationLayer.Features.CQRS.Handlers.OrderDetailHandlers;
using TakeAway.ApplicationLayer.Features.CQRS.Queries.OrderDetailQueries;

namespace TakeAway.OrderPresentationLayer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderDetailsController(GetOrderDetailQueryHandler getOrderDetailQueryHandler, GetOrderDetailByIdQueryHandler getOrderDetailByIdQueryHandler, CreateOrderDetailCommandHandler createOrderDetailCommandHandler, UpdateOrderDetailCommandHandler updateOrderDetailCommandHandler, DeleteOrderDetailCommandHandler deleteOrderDetailCommandHandler) : ControllerBase
{
    private readonly GetOrderDetailQueryHandler _getOrderDetailQueryHandler = getOrderDetailQueryHandler;
    private readonly GetOrderDetailByIdQueryHandler _getOrderDetailByIdQueryHandler = getOrderDetailByIdQueryHandler;
    private readonly CreateOrderDetailCommandHandler _createOrderDetailCommandHandler = createOrderDetailCommandHandler;
    private readonly UpdateOrderDetailCommandHandler _updateOrderDetailCommandHandler = updateOrderDetailCommandHandler;
    private readonly DeleteOrderDetailCommandHandler _deleteOrderDetailCommandHandler = deleteOrderDetailCommandHandler;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var values = await _getOrderDetailQueryHandler.Handle();
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var values = await _getOrderDetailByIdQueryHandler.Handle(new GetOrderDetailByIdQuery(id));
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderDetailCommand createOrderDetailCommand)
    {
        await _createOrderDetailCommandHandler.Handle(createOrderDetailCommand);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> Update(UpdateOrderDetailCommand updateOrderDetailCommand)
    {
        await _updateOrderDetailCommandHandler.Handle(updateOrderDetailCommand);
        return Ok();
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
        await _deleteOrderDetailCommandHandler.Handle(new DeleteOrderDetailCommand(id));
        return Ok();
    }
}
