
using PatientsApplicationMicroservice.Application.Dtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    public class AppointmentsServiceClient:IAppointmentsServiceClient
    {
        public IHttpClientFactory clientFactory;

        public AppointmentsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        const string host = "http://appointments_data:80/";
        public async Task<IEnumerable<AppointmentDto>> GetAppointmentsByPatientId(int patientId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                string.Format("{0}getAppointmentByPatientId?patientId={0}", host, patientId));
            request.Headers.Add("Accept", "application/json");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            return await JsonSerializer.DeserializeAsync<IEnumerable<AppointmentDto>>(responseStream, options);
        }
    }
}

