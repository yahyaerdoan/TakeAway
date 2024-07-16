using TakeAway.ApplicationLayer.Features.CQRS.Commands.AddressCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.AddressHandlers;

public class UpdateAddressCommandHandler(IRepository<Address> repository)
{
    private readonly IRepository<Address> repository = repository;

    public async Task Hande(UpdateAddressCommand command)
    {
        var values = await repository.GetByIdAsync(command.Id);
        values.UserId = command.UserId;
        values.Name = command.Name;
        values.Surname = command.Surname;
        await repository.UpdateAsync(values);
    }
}
