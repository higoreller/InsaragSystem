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
    public class AddressCreateCommandHandler : IRequestHandler<AddressCreateCommand, Address>
    {
        private IAddressRepository _addressRepository;

        public AddressCreateCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<Address> Handle(AddressCreateCommand request, CancellationToken cancellationToken)
        {
            var Address = new Address()
            {
                TeamId = request.TeamId 
            };


            if (Address == null)
            {
                throw new ApplicationException($"Error creating entity.");
            } else
            {
                return await _addressRepository.CreateAsync(Address);
            }
        }
    }
}
