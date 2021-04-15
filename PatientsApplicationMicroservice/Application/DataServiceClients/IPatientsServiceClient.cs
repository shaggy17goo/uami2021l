namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using PatientsApplicationMicroservice.Application.Dtos;

    public interface IPatientsServiceClient 
    {
        Task<PatientDto> GetPatientById(int patientId);
    }
}
