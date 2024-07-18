using MediatR;
using TakeAway.ApplicationLayer.Features.Mediator.Queries.OrderQueries;
using TakeAway.ApplicationLayer.Features.Mediator.Results.OrderResults;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.Mediator.Handlers.OrderHandlers;

public class GetOrderQueryHandler(IRepository<Order> repository) : IRequestHandler<GetOrderQuery, List<GetOrderQueryResult>>
{
    private readonly IRepository<Order> _repository = repository;

    public async Task<List<GetOrderQueryResult>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAsync();

        return values.Select(x => new GetOrderQueryResult
        {
            Id = x.Id,
            UserId= x.UserId,
            TotalPrice = x.TotalPrice,
            OrderDate = x.OrderDate,
        }).ToList(); 
    }
}