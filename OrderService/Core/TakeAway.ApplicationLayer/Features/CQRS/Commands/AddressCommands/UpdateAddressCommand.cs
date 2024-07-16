namespace TakeAway.ApplicationLayer.Features.CQRS.Commands.AddressCommands;

public class UpdateAddressCommand
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