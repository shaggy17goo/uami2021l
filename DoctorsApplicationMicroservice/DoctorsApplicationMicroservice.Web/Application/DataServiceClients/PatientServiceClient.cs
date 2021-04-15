using System.Text;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Commands.Commands;
    using Dtos;

    public class PatientServiceClient : IPatientServiceClient
    {
        private readonly JsonSerializerOptions _options;
        private readonly GenericServiceClient _serviceClient;
        public PatientServiceClient(IHttpClientFactory clientFactory)
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            _serviceClient = new GenericServiceClient(clientFactory);
        }

        public async Task<IEnumerable<PatientDto>> GetAllAsync()
        {
            const string requestUri = "https://localhost:44391/listPatients";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<IEnumerable<PatientDto>>(responseStream, _options);

        }

        public async Task<PatientDto> GetPatientById(int patientId)
        {
            var requestUri = $"https://localhost:44391/getPatientById?patientId={patientId}";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<PatientDto>(responseStream, _options);
        }

        public async Task<PatientDto> GetPatientByPESEL(string PESEL)
        {
            var requestUri = $"https://localhost:44391/getPatientByPESEL?PESEL={PESEL}";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<PatientDto>(responseStream, _options);
        }

        public void AddPatient(AddPatientCommand addPatientCommand)
        {
            const string url = "https://localhost:44391/addPatient";
            _serviceClient.PostData(url, addPatientCommand);
        }

        public void DeletePatient(DeletePatientCommand deletePatientCommand)
        {
            const string url = "https://localhost:44391/deletePatient";
            _serviceClient.PostData(url, deletePatientCommand);
        }
        
    }
}