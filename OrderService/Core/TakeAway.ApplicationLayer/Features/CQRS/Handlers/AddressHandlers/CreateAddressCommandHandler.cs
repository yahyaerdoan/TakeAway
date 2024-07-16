using TakeAway.ApplicationLayer.Features.CQRS.Commands.AddressCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.AddressHandlers;

public class CreateAddressCommandHandler(IRepository<Address> repository)
{
    private readonly IRepository<Address> repository = repository;

    public async Task Handle(CreateAddressCommand command)
    {
        await repository.CreateAsync(new Address
        {
            UserId = command.UserId,
            Name = command.Name,
            Surname = command.Surname,
        });      
    }
}
