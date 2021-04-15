using System.Collections.Generic;
using System.Threading.Tasks;
using ExaminationRoomsSelector.Web.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using PatientsData.Web.Application.Commands;

namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    public interface IAppointmentServiceClient
    {
        public  Task<IEnumerable<AppointmentDto>> GetAllAsync();


        public  Task<IEnumerable<AppointmentDto>> GetAppointmentByDoctorId([FromQuery] int doctorId);


        public  Task<IEnumerable<AppointmentDto>> GetAppointmentByPatientId([FromQuery] int patientId);


        public  Task<AppointmentDto> GetAppointmentById([FromQuery] int appointmentId);


        public void AddAppointment([FromBody] AddAppointmentCommand appointmentCommand);


        public void DeleteAppointment([FromBody] DeleteAppointmentCommand appointmentCommand);


    }
}