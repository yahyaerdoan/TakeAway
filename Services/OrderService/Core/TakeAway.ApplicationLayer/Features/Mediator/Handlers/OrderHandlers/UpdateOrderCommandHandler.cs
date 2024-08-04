using MediatR;
using TakeAway.ApplicationLayer.Features.Mediator.Commands.OrderCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.Mediator.Handlers.OrderHandlers;

public class UpdateOrderCommandHandler(IRepository<Order> repository) : IRequestHandler<UpdateOrderCommand>
{
    private readonly IRepository<Order> repository = repository;

    public async Task Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        var values = await repository.GetByIdAsync(request.Id);
        values.UserId = request.UserId;
        values.TotalPrice = request.TotalPrice;
        values.OrderDate = request.OrderDate;
        await repository.UpdateAsync(values);       
    }
}
