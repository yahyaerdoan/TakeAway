using MediatR;
using TakeAway.ApplicationLayer.Features.Mediator.Commands.OrderCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.Mediator.Handlers.OrderHandlers;

public class DeleteOrderCommandHandler(IRepository<Order> repository) : IRequestHandler<DeleteOrderCommand>
{
    private readonly IRepository<Order> repository = repository;

    public async Task Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        await repository.DeleteAsync(request.Id);
    }
}
