using InsaragSystem.Application.Addresses.Queries;
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
    public class GetAddressByIdQueryHandler : IRequestHandler<GetAddressByIdQuery, Address>
    {
        private readonly IAddressRepository _addressRepository;

        public GetAddressByIdQueryHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<Address> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
        {
            return await _addressRepository.GetAddressByIdAsync(request.AddressId);
        }
    }
}
