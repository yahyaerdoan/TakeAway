using TakeAway.ApplicationLayer.Features.CQRS.Commands.OrderDetailCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.OrderDetailHandlers;

public class DeleteOrderDetailCommandHandler(IRepository<OrderDetail> repository)
{
    private readonly IRepository<OrderDetail> _repository = repository;

    public async Task Handle(DeleteOrderDetailCommand command)
    {
        await _repository.DeleteAsync(command.Id);
    
    }
}

