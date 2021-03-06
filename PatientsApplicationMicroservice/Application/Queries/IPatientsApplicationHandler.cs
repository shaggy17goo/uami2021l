namespace PatientsApplicationMicroservice.Application.Queries
{
    using PatientsApplicationMicroservice.Application.Dtos;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPatientsApplicationHandler
    {
        Task<PatientDto> GetPatientById(int patientId);
    }
}
