using System.Collections.Generic;
using System.Threading.Tasks;
using ExaminationRoomsSelector.Web.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using PatientsData.Web.Application.Commands;

namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    public interface IPatientServiceClient
    {
        public Task<IEnumerable<PatientDto>> GetAllAsync();

        public Task<PatientDto> GetPatientById([FromQuery] int patientId);
        
        public Task<PatientDto> GetPatientByPESEL([FromQuery] string PESEL);
        
        public void AddPatient([FromBody] AddPatientCommand patientCommand);
        
        public void DeletePatient([FromBody] DeleteAppointmentCommand appointmentCommand);
    }
}