using TakeAway.ApplicationLayer.Features.CQRS.Results.AddressResults;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.AddressHandlers;

public class GetAddressQueryHandler(IRepository<Address> repository)
{
    private readonly IRepository<Address> repository = repository;

    public async Task<List<GetAddressQueryResult>> Handle()
    {
        var values = await repository.GetAsync();
        return values.Select(x=> new GetAddressQueryResult{
            Id = x.Id,
            UserId = x.UserId,
            Name = x.Name,
            Surname = x.Surname,
            Email = x.Email,
            City = x.City,
            District = x.District,
            Detail = x.Detail,
        }).ToList();
    }
}
