using MediatR;

namespace TakeAway.ApplicationLayer.Features.Mediator.Commands.OrderCommands;

public class UpdateOrderCommand : IRequest
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
}

