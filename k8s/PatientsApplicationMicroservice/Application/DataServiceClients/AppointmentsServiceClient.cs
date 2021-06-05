
using PatientsApplicationMicroservice.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    public class AppointmentsServiceClient:IAppointmentsServiceClient
    {
        public IHttpClientFactory clientFactory;
        public string Host;

        public AppointmentsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
            Host = Environment.GetEnvironmentVariable("APPOINTMENTS_HOST");
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentsByPatientId(int patientId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                string.Format("{0}getAppointmentByPatientId?patientId={1}", Host, patientId));
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

