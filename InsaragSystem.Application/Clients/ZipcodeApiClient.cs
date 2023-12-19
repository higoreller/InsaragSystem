using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using InsaragSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsaragSystem.Application.DTOs;
using System.Reflection.Emit;

namespace InsaragSystem.Application.Clients
{
    public class ZipcodeApiClient
    {
        private readonly HttpClient _httpClient;

        public ZipcodeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AddressDTO> GetAddressByZipcodeAsync(string zipCode)
        {
            var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{zipCode}/json/");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var address = JsonConvert.DeserializeObject<AddressResponse>(content);

            return new AddressDTO
            {
                ZipCode = zipCode,
                Street = address.Logradouro,
                District = address.Bairro,
                City = address.Localidade,
                State = address.Uf
            };
        }
    }
}
