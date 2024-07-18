using MediatR;

namespace TakeAway.ApplicationLayer.Features.Mediator.Commands.OrderCommands;

public class DeleteOrderCommand(int id) : IRequest
{
    public int Id { get; set; } = id;
}

