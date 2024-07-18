using TakeAway.ApplicationLayer.Features.CQRS.Results.OrderDetailResults;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.OrderDetailHandlers;

public class GetOrderDetailQueryHandler(IRepository<OrderDetail> repository)
{
    private readonly IRepository<OrderDetail> _repository = repository;

    public async Task<List<GetOrderDetailQueryResult>> Handle()
    {
        var values = await _repository.GetAsync();
        return values.Select(x => new GetOrderDetailQueryResult
        {
            Id = x.Id,
            ProductName = x.ProductName,
            TotalPrice = x.TotalPrice,
            ProductId = x.ProductId,
            Amount = x.Amount,
            OrderId = x.OrderId,
            Price = x.Price,

        }).ToList();
    }
}

