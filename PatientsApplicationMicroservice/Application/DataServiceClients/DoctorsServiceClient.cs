using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatientsApplicationMicroservice.Application.Dtos;
using System.Net.Http;
using System.Text.Json;

namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    public class DoctorsServiceClient : IDoctorsServiceClient
    {

        public IHttpClientFactory clientFactory;
        
        public DoctorsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IEnumerable<DoctorDto>> GetAllDoctors()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://localhost:44392/doctors");
            request.Headers.Add("Accept", "application/json");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            return await JsonSerializer.DeserializeAsync<IEnumerable<DoctorDto>>(responseStream, options);
        }
    }
}
