namespace PatientsApplicationMicroservice.Application.Queries
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using PatientsApplicationMicroservice.Application.DataServiceClients;
    using PatientsApplicationMicroservice.Application.Dtos;

    public class PatientsApplicationHandler : IPatientsApplicationHandler
    {
        private readonly IPatientsServiceClient patientsServiceClient;

        public PatientsApplicationHandler(IPatientsServiceClient patientsServiceClient)
        {
            this.patientsServiceClient = patientsServiceClient;
        }

        public async Task<PatientDto> GetPatientById(int patientId)
        {
            return await patientsServiceClient.GetPatientById(patientId);
        }
    }
}
