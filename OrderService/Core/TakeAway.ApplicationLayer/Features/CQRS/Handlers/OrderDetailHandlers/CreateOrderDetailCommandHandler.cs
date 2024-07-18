using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.ApplicationLayer.Features.CQRS.Commands.OrderDetailCommands;
using TakeAway.ApplicationLayer.Features.CQRS.Queries.AddressQueries;
using TakeAway.ApplicationLayer.Features.CQRS.Results.AddressResults;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.OrderDetailHandlers;

public class CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
{
    private readonly IRepository<OrderDetail> _repository = repository;

    public async Task Handle(CreateOrderDetailCommand command)
    {
        await _repository.CreateAsync(new OrderDetail
        {
            OrderId = command.OrderId,
            Amount = command.Amount,
            Price = command.Price,
            ProductId = command.ProductId,
            ProductName = command.ProductName,
            TotalPrice = command.TotalPrice,
        });
    }
}

