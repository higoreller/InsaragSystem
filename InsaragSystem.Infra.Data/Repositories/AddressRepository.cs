using InsaragSystem.Domain.Entities;
using InsaragSystem.Domain.Interfaces;
using InsaragSystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _addressContext;

        public AddressRepository(ApplicationDbContext addressContext)
        {
            _addressContext = addressContext;
        }

        public async Task<Address> CreateAsync(Address address)
        {
            _addressContext.Add(address);
            await _addressContext.SaveChangesAsync();
            return address;
        }

        public async Task<Address> GetAddressByIdAsync(int? id)
        {
            return await _addressContext.Addresses.FindAsync(id);
        }

        public async Task<IEnumerable<Address>> GetAddressesAsync()
        {
            return await _addressContext.Addresses.ToListAsync();
        }

        public async Task<Address> RemoveAsync(Address address)
        {
            _addressContext.Addresses.Remove(address);
            await _addressContext.SaveChangesAsync();
            return address;
        }

        public async Task<Address> UpdateAsync(Address address)
        {
            _addressContext.Addresses.Update(address);
            await _addressContext.SaveChangesAsync();
            return address;
        }
    }
}
