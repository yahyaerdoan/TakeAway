using TakeAway.ApplicationLayer.Features.CQRS.Commands.OrderDetailCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.OrderDetailHandlers;

public class UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
{
    private readonly IRepository<OrderDetail> _repository = repository;

    public async Task Handle(UpdateOrderDetailCommand command)
    {
      var values =  await _repository.GetByIdAsync(command.Id);
        values.ProductName = command.ProductName;
        values.TotalPrice = command.TotalPrice;
        values.ProductId = command.ProductId;
        values.ProductName = command.ProductName;
        values.TotalPrice = command.TotalPrice;
        await _repository.UpdateAsync(values);      
    }
}

