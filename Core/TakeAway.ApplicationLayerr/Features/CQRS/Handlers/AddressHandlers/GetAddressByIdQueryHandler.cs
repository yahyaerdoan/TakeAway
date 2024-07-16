using TakeAway.ApplicationLayer.Features.CQRS.Queries.AddressQueries;
using TakeAway.ApplicationLayer.Features.CQRS.Results.AddressResults;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.AddressHandlers;

public class GetAddressByIdQueryHandler(IRepository<Address> addressRepository)
{
    private readonly IRepository<Address> _addressRepository = addressRepository;

    public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
    {
        var values = await _addressRepository.GetByIdAsync(query.Id);
        return new GetAddressByIdQueryResult
        {
            Id = values.Id,
            UserId = values.UserId,
            Name = values.Name,
            Email = values.Email,
        };
    }
}
