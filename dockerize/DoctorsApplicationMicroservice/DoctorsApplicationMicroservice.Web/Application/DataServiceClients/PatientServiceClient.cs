using System.Text;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System;
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
            string requestUri = String.Format("{0}listPatients", host);

            return await _serviceClient.GetData<IEnumerable<PatientDto>>(requestUri);

        }

        public async Task<PatientDto> GetPatientById(int patientId)
        {
            string requestUri = String.Format("{0}getPatientById?patientId={1}", host, patientId);

            return await _serviceClient.GetData<PatientDto>(requestUri);
        }

        public async Task<PatientDto> GetPatientByPESEL(string pesel)
        {
            string requestUri = String.Format("{0}getPatientByPESEL?PESEL={1}", host, pesel);

            return await _serviceClient.GetData<PatientDto>(requestUri);
        }

        public int AddPatient(AddPatientCommand addPatientCommand)
        {
            string requestUri = String.Format("{0}addPatient", host);
            return _serviceClient.PostData(requestUri, addPatientCommand);
        }

        public int DeletePatient(DeletePatientCommand deletePatientCommand)
        {
            string requestUri = String.Format("{0}deletePatient", host);
            return _serviceClient.PostData(requestUri, deletePatientCommand);
        }
        
    }
}