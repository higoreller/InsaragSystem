using InsaragSystem.Application.Addresses.Commands;
using InsaragSystem.Domain.Entities;
using InsaragSystem.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Addresses.Handlers
{
    public class AddressUpdateCommandHandler : IRequestHandler<AddressUpdateCommand, Address>
    {
        private readonly IAddressRepository _addressRepository;
        public AddressUpdateCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository ?? throw new
                ArgumentNullException(nameof(addressRepository));
        }

        public async Task<Address> Handle(AddressUpdateCommand request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAddressByIdAsync(request.AddressId);

            if(address == null)
            {
                throw new ApplicationException($"Entity could not be found.");
            } else
            {
                return await _addressRepository.UpdateAsync(address);
            }
        }
    }
}
