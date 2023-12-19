using InsaragSystem.Domain.Entities;
using MediatR;

namespace InsaragSystem.Application.Addresses.Commands
{
    public abstract class AddressCommand : IRequest<Address>
    {
        public int AddressId { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int TeamId { get; set; }
    }
}
