namespace TakeAway.ApplicationLayer.Features.CQRS.Results.AddressResults;

public class GetAddressByIdQueryResult
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string Detail { get; set; }
}
