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

        const string host = "http://patients_data:80/";


        public async Task<IEnumerable<PatientDto>> GetAllAsync()
        {
            const string requestUri = host +"listPatients";

            return await _serviceClient.GetData<IEnumerable<PatientDto>>(requestUri);

        }

        public async Task<PatientDto> GetPatientById(int patientId)
        {
            var requestUri = host + $"getPatientById?patientId={patientId}";

            return await _serviceClient.GetData<PatientDto>(requestUri);
        }

        public async Task<PatientDto> GetPatientByPESEL(string pesel)
        {
            var requestUri = host + $"getPatientByPESEL?PESEL={pesel}";

            return await _serviceClient.GetData<PatientDto>(requestUri);
        }

        public int AddPatient(AddPatientCommand addPatientCommand)
        {
            const string url = host + "addPatient";
            return _serviceClient.PostData(url, addPatientCommand);
        }

        public int DeletePatient(DeletePatientCommand deletePatientCommand)
        {
            const string url = host + "deletePatient";
            return _serviceClient.PostData(url, deletePatientCommand);
        }
        
    }
}