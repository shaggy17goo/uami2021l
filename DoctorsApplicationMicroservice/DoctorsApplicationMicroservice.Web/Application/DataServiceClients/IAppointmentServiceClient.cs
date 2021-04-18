namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Commands.Commands;
    using Dtos;
    using Microsoft.AspNetCore.Mvc;

    public interface IAppointmentServiceClient
    {
        public  Task<IEnumerable<AppointmentDto>> GetAllAsync();


        public  Task<IEnumerable<AppointmentDto>> GetAppointmentByDoctorId([FromQuery] int doctorId);


        public  Task<IEnumerable<AppointmentDto>> GetAppointmentByPatientId([FromQuery] int patientId);


        public  Task<AppointmentDto> GetAppointmentById([FromQuery] int appointmentId);


        public int AddAppointment([FromBody] AddAppointmentCommand addAppointmentCommand);


        public int DeleteAppointment([FromBody] DeleteAppointmentCommand deleteAppointmentCommand);


    }
}