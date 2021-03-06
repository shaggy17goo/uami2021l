namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Net.Http;
    using System.Text.Json;

    using PatientsApplicationMicroservice.Application.Dtos;

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
                $"https://localhost:44393/doctors");
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
        public async Task<DoctorDto> GetDoctorById(int doctorId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                string.Format("https://localhost:44393/getDoctorById?doctorId={0}",doctorId));
            request.Headers.Add("Accept", "application/json");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            return await JsonSerializer.DeserializeAsync<DoctorDto>(responseStream, options);
        }
    }
}
