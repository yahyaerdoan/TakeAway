using MediatR;
using TakeAway.ApplicationLayer.Features.Mediator.Queries.OrderQueries;
using TakeAway.ApplicationLayer.Features.Mediator.Results.OrderResults;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.Mediator.Handlers.OrderHandlers;

public class GetOrderByIdQueryHandler(IRepository<Order> repository) : IRequestHandler<GetOrderByIdQuery, GetOrderByIdQueryResult>
{
    private readonly IRepository<Order> _repository = repository;

    public async Task<GetOrderByIdQueryResult> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIdAsync(request.Id);
        return new GetOrderByIdQueryResult
        {
            Id = values.Id,
            UserId = values.UserId,
            TotalPrice = values.TotalPrice,
            OrderDate = values.OrderDate,
        };
    }
}
