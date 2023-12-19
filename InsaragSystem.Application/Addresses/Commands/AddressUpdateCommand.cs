using InsaragSystem.Domain.Entities;
using MediatR;

namespace InsaragSystem.Application.Addresses.Commands
{
    public class AddressUpdateCommand : AddressCommand
    {
        public int AddressId { get; set; }

    }
}
