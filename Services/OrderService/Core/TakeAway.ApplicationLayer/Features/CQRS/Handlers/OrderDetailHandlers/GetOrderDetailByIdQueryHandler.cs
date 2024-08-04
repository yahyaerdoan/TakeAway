using TakeAway.ApplicationLayer.Features.CQRS.Queries.OrderDetailQueries;
using TakeAway.ApplicationLayer.Features.CQRS.Results.OrderDetailResults;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.OrderDetailHandlers;

public class GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
{
    private readonly IRepository<OrderDetail> _repository = repository;

    public async Task<GetOrderDetailQueryResult> Handle(GetOrderDetailByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetOrderDetailQueryResult
        {
            Id = values.Id,
            Price = values.Price,
            TotalPrice = values.TotalPrice,
            ProductId = values.ProductId,
            ProductName = values.ProductName,
            OrderId = values.OrderId,
            Amount = values.Amount,           
        };
    }
}

