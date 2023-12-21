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
            var address = new Address()
            {
                AddressId = request.AddressId,
                ZipCode = request.ZipCode,
                Street = request.Street,
                District = request.District,
                City = request.City,
                State = request.State,
                TeamId = request.TeamId
            };

            return await _addressRepository.CreateAsync(address);
        }
    }
}
