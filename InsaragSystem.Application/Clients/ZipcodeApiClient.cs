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
    public class ZipCodeApiClient
    {
        private readonly HttpClient _httpClient;

        public ZipCodeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AddressDTO> GetAddressByZipCodeAsync(string zipCode)
        {
            var response = await _httpClient.GetAsync($"{zipCode}/json/");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var address = JsonConvert.DeserializeObject<AddressResponse>(content);
            var addressCity = address.Localidade;

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
