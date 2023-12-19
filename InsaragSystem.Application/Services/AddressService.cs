using AutoMapper;
using InsaragSystem.Application.DTOs;
using InsaragSystem.Application.Interfaces;
using InsaragSystem.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using InsaragSystem.Application.Addresses.Commands;
using InsaragSystem.Application.Addresses.Queries;

namespace InsaragSystem.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public AddressService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task AddAddress(AddressDTO addressDto)
        {
            var createCommand = _mapper.Map<AddressCreateCommand>(addressDto);
            await _mediator.Send(createCommand);
        }

        public async Task<AddressDTO> GetAddressById(int id)
        {
            var addressQuery = new GetAddressByIdQuery(id);
            var address = await _mediator.Send(addressQuery);
            return _mapper.Map<AddressDTO>(address);
        }

        public async Task<IEnumerable<AddressDTO>> GetAddresses()
        {
            var addressesQuery = new GetAddressesQuery();
            var addresses = await _mediator.Send(addressesQuery);
            return _mapper.Map<IEnumerable<AddressDTO>>(addresses);
        }

        public async Task RemoveAddress(int? id)
        {
            var deleteCommand = new AddressRemoveCommand(id.Value);
            if (deleteCommand == null)
            {
                throw new Exception("Entity could not be removed.");
            }
            else
            {
                await _mediator.Send(deleteCommand);
            }
        }

        public async Task UpdateAddress(AddressDTO addressDto)
        {
            var updateCommand = _mapper.Map<AddressUpdateCommand>(addressDto);
            await _mediator.Send(updateCommand);
        }
    }
}
