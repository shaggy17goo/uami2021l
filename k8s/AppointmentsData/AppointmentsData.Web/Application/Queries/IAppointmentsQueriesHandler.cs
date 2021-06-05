using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentsData.Domain.PatientAggregate;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentsData.Web.Application.Queries
{
    public interface IAppointmentsQueriesHandler
    {
        Task<IEnumerable<Appointment>> GetAllAsync();
        Task<IEnumerable<Appointment>> GetAllAppointmentsOfDoctor([FromQuery] int doctorId);
        Task<IEnumerable<Appointment>> GetAllAppointmentsOfPatient([FromQuery] int patientId);

        Task<Appointment> GetAppointmentById([FromQuery] int patientId);
    }
}