using System.Collections.Generic;
using System.Threading.Tasks;
using ExaminationRoomsSelector.Web.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    public interface IAppointmentServiceClient
    {
        Task<IEnumerable<AppointmentDto>> GetAllAsync();
        
        Task<IEnumerable<AppointmentDto>> GetAllAppointmentsOfDoctor([FromQuery] int doctorId);
        
        Task<IEnumerable<AppointmentDto>> GetAllAppointmentsOfPatient([FromQuery] int patientId);
        
        Task<AppointmentDto> GetAppointmentById([FromQuery] int patientId);

    }
}