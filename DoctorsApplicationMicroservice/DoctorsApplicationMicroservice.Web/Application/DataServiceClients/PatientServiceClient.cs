using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ExaminationRoomsSelector.Web.Application.Dtos;
using PatientsData.Web.Application.Commands;

namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    public class PatientServiceClient : IPatientServiceClient
    {
        public readonly IHttpClientFactory ClientFactory;

        public PatientServiceClient(IHttpClientFactory clientFactory)
        {
            ClientFactory = clientFactory;
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

        public void AddPatient(AddPatientCommand patientCommand)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePatient(DeletePatientCommand appointmentCommand)
        {
            throw new System.NotImplementedException();
        }
        
    }
}