using TakeAway.ApplicationLayer.Features.CQRS.Commands.AddressCommands;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Handlers.AddressHandlers;

public class DeleteAddressCommandHandler(IRepository<Address> addressRepository)
{
    private readonly IRepository<Address> _addressRepository = addressRepository;

    public async Task Handle(DeleteAddressCommand command)
    {
        await _addressRepository.DeleteAsync(command.Id);
    }
}
