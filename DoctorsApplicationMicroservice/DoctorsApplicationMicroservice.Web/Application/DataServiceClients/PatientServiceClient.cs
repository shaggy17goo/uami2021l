using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using DoctorsApplicationMicroservice.Web.Application.DataServiceClients;
using ExaminationRoomsSelector.Web.Application.Dtos;
using PatientsData.Web.Application.Commands;

namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
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

        public Task<IEnumerable<PatientDto>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PatientDto> GetPatientById(int patientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<PatientDto> GetPatientByPESEL(string PESEL)
        {
            throw new System.NotImplementedException();
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