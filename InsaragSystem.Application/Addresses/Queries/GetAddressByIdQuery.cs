using InsaragSystem.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Addresses.Queries
{
    public class GetAddressByIdQuery : IRequest<Address>
    {
        public int AddressId { get; set; }
        public GetAddressByIdQuery(int addressId)
        {

            AddressId = addressId;

        }
    }
}
