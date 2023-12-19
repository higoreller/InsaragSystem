using InsaragSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Interfaces
{
    public interface IAddressService
    {
        Task<IEnumerable<AddressDTO>> GetAddresses();
        Task<AddressDTO> GetAddressById(int id);
        Task AddAddress(AddressDTO addressDto);
        Task UpdateAddress(AddressDTO addressDto);
        Task RemoveAddress(int? id);
    }
}
