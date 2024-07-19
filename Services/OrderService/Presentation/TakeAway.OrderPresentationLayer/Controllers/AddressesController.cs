using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.ApplicationLayer.Features.CQRS.Commands.AddressCommands;
using TakeAway.ApplicationLayer.Features.CQRS.Handlers.AddressHandlers;
using TakeAway.ApplicationLayer.Features.CQRS.Queries.AddressQueries;

namespace TakeAway.OrderPresentationLayer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressesController(GetAddressQueryHandler getAddressqueryHandler, GetAddressByIdQueryHandler getAddressByIdQueryHandler, CreateAddressCommandHandler createAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler, DeleteAddressCommandHandler deleteAddressCommandHandler) : ControllerBase
{
    private readonly GetAddressQueryHandler _getAddressqueryHandler = getAddressqueryHandler;
    private readonly GetAddressByIdQueryHandler _getAddressByIdQueryHandler = getAddressByIdQueryHandler;
    private readonly CreateAddressCommandHandler _createAddressCommandHandler = createAddressCommandHandler;
    private readonly UpdateAddressCommandHandler _updateAddressCommandHandler = updateAddressCommandHandler;
    private readonly DeleteAddressCommandHandler _deleteAddressCommandHandler = deleteAddressCommandHandler;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var values = await _getAddressqueryHandler.Handle();
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var values = await _getAddressByIdQueryHandler.Handle(new GetAddressByIdQuery(id));
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateAddressCommand createAddressCommand)
    {
        await _createAddressCommandHandler.Handle(createAddressCommand);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> Update(UpdateAddressCommand updateAddressCommand)
    {
        await _updateAddressCommandHandler.Handle(updateAddressCommand);
        return Ok();
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
       await _deleteAddressCommandHandler.Handle(new DeleteAddressCommand(id));
        return Ok();
    }
}
