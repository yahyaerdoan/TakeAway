using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.ApplicationLayer.Features.Mediator.Commands.OrderCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.Mediator.Handlers.OrderHandlers;

public class CreateOrderCommandHandler(IRepository<Order> repository) : IRequestHandler<CreateOrderCommand>
{
    private readonly IRepository<Order> repository = repository;

    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        await repository.CreateAsync(new Order
        {
            UserId = request.UserId,
            OrderDate = request.OrderDate,
            TotalPrice = request.TotalPrice,
       });
    }
}
