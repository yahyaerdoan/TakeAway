using TakeAway.ApplicationLayer.Features.CQRS.Commands.AddressCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.AddressHandlers;

public class UpdateAddressCommandHandler(IRepository<Address> repository)
{
    private readonly IRepository<Address> repository = repository;

    public async Task Handle(UpdateAddressCommand command)
    {
        var values = await repository.GetByIdAsync(command.Id);
        values.UserId = command.UserId;
        values.Name = command.Name;
        values.Surname = command.Surname;
        values.Email = command.Email;
        values.City = command.City;
        values.District = command.District;
        values.Detail = command.Detail;
        await repository.UpdateAsync(values);
    }
}
