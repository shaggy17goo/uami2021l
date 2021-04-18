using System.Text;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Commands.Commands;
    using Dtos;

    public class PatientServiceClient : IPatientServiceClient
    {
        private readonly GenericServiceClient _serviceClient;
        public PatientServiceClient(IHttpClientFactory clientFactory)
        {
            _serviceClient = new GenericServiceClient(clientFactory);
        }

        public async Task<IEnumerable<PatientDto>> GetAllAsync()
        {
            const string requestUri = "https://localhost:44391/listPatients";

            return await _serviceClient.GetData<IEnumerable<PatientDto>>(requestUri);

        }

        public async Task<PatientDto> GetPatientById(int patientId)
        {
            var requestUri = $"https://localhost:44391/getPatientById?patientId={patientId}";

            return await _serviceClient.GetData<PatientDto>(requestUri);
        }

        public async Task<PatientDto> GetPatientByPESEL(string pesel)
        {
            var requestUri = $"https://localhost:44391/getPatientByPESEL?PESEL={pesel}";

            return await _serviceClient.GetData<PatientDto>(requestUri);
        }

        public int AddPatient(AddPatientCommand addPatientCommand)
        {
            const string url = "https://localhost:44391/addPatient";
            return _serviceClient.PostData(url, addPatientCommand);
        }

        public int DeletePatient(DeletePatientCommand deletePatientCommand)
        {
            const string url = "https://localhost:44391/deletePatient";
            return _serviceClient.PostData(url, deletePatientCommand);
        }
        
    }
}