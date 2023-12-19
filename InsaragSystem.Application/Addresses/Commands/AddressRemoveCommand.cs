using InsaragSystem.Domain.Entities;
using MediatR;

namespace InsaragSystem.Application.Addresses.Commands
{
    public class AddressRemoveCommand : IRequest<Address>
    {
        public int AddressId { get; set; }

        public AddressRemoveCommand(int addressId)
        {
            AddressId = addressId;
        }
    }
}
