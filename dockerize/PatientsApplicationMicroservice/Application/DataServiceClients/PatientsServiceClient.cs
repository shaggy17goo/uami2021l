namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    using PatientsApplicationMicroservice.Application.Dtos;

    public class PatientsServiceClient : IPatientsServiceClient
    {
        public IHttpClientFactory clientFactory;
        public PatientsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        const string host = "http://patients_data:80/";

        public async Task<PatientDto> GetPatientById(int patientId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
             string.Format(host + "getPatientById?patientId={0}",patientId));
            request.Headers.Add("Accept", "application/json");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            return await JsonSerializer.DeserializeAsync<PatientDto>(responseStream, options);
        }
    }
}
