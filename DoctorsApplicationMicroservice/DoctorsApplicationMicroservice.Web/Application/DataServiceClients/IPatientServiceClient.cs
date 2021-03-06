namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Commands.Commands;
    using Dtos;
    using Microsoft.AspNetCore.Mvc;

    public interface IPatientServiceClient
    {
        public Task<IEnumerable<PatientDto>> GetAllAsync();

        public Task<PatientDto> GetPatientById([FromQuery] int patientId);
        
        public Task<PatientDto> GetPatientByPESEL([FromQuery] string PESEL);
        
        public int AddPatient([FromBody] AddPatientCommand addPatientCommand);
        
        public int DeletePatient([FromBody] DeletePatientCommand deletePatientCommand);
    }
}