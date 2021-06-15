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
        public string Host;

        public PatientServiceClient(IHttpClientFactory clientFactory)
        {
            _serviceClient = new GenericServiceClient(clientFactory);
            Host = Environment.GetEnvironmentVariable("PATIENTS_HOST");

        }

        public async Task<IEnumerable<PatientDto>> GetAllAsync()
        {
            string requestUri = string.Format("{0}listPatients", Host);
            return await _serviceClient.GetData<IEnumerable<PatientDto>>(requestUri);

        }

        public async Task<PatientDto> GetPatientById(int patientId)
        {
            string requestUri = string.Format("{0}getPatientById?patientId={1}", Host, patientId);

            return await _serviceClient.GetData<PatientDto>(requestUri);
        }

        public async Task<PatientDto> GetPatientByPESEL(string pesel)
        {
            string requestUri = string.Format("{0}getPatientByPESEL?PESEL={1}", Host, pesel);


            return await _serviceClient.GetData<PatientDto>(requestUri);
        }

        public int AddPatient(AddPatientCommand addPatientCommand)
        {
            string url = string.Format("{0}addPatient", Host);

            return _serviceClient.PostData(url, addPatientCommand);
        }

        public int DeletePatient(DeletePatientCommand deletePatientCommand)
        {
            string url = string.Format("{0}deletePatient", Host);
            return _serviceClient.PostData(url, deletePatientCommand);
        }
        
    }
}