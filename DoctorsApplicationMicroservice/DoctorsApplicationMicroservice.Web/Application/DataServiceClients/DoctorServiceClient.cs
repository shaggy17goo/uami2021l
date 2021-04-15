namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class DoctorServiceClient : IDoctorServiceClient
    {
        public readonly IHttpClientFactory ClientFactory;
        public DoctorServiceClient(IHttpClientFactory clientFactory)
        {
            this.ClientFactory = clientFactory;
        }
        

        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://localhost:44392/doctors");
            request.Headers.Add("Accept", "application/json");

            var client = ClientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            return await JsonSerializer.DeserializeAsync<IEnumerable<DoctorDto>>(responseStream, options);
        }
        
        public Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            throw new NotImplementedException();
        }
    }
}
