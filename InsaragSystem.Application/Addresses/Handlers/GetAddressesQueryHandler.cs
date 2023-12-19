using InsaragSystem.Application.Addresses.Queries;
using InsaragSystem.Application.Teams.Queries;
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
    public class GetAddressesQueryHandler : IRequestHandler<GetAddressesQuery, IEnumerable<Address>>
    {
        private readonly IAddressRepository _addressRepository;

        public GetAddressesQueryHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<IEnumerable<Address>> Handle(GetAddressesQuery request, CancellationToken cancellationToken)
        {
            return await _addressRepository.GetAddressesAsync();
        }


    }
}
