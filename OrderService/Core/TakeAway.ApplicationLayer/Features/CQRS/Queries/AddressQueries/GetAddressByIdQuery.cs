namespace TakeAway.ApplicationLayer.Features.CQRS.Queries.AddressQueries;

public class GetAddressByIdQuery(int id)
{
    public int Id { get; set; } = id;
}
