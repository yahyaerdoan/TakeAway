using MediatR;
using TakeAway.ApplicationLayer.Features.Mediator.Results.OrderResults;

namespace TakeAway.ApplicationLayer.Features.Mediator.Queries.OrderQueries;

public class GetOrderByIdQuery(int id) : IRequest<GetOrderByIdQueryResult>
{
    public int Id { get; set; } = id;
}
