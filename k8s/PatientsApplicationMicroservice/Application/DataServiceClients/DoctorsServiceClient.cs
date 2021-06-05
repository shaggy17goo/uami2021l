namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Net.Http;
    using System.Text.Json;

    using PatientsApplicationMicroservice.Application.Dtos;
    using System;

    public class DoctorsServiceClient : IDoctorsServiceClient
    {
        public IHttpClientFactory clientFactory;
        public string Host;
        public DoctorsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
            Host = Environment.GetEnvironmentVariable("DOCTORS_HOST");
        }

        public async Task<IEnumerable<DoctorDto>> GetAllDoctors()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, Host + "doctors");
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
                string.Format("{0}getDoctorById?doctorId={1}", Host, doctorId));
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
