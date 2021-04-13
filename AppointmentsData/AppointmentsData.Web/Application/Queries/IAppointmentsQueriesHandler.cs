namespace AppointmentsData.Web.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using AppointmentsData.Domain.PatientAggregate;
    using AppointmentsData.Web.Application.Commands;

    public interface IAppointmentsQueriesHandler
    {
        Task<IEnumerable<Appointment>> GetAllAsync();
        Task<IEnumerable<Appointment>> GetAllAppointmentsOfDoctor([FromQuery] int doctorId);
        Task<IEnumerable<Appointment>> GetAllAppointmentsOfPatient([FromQuery] int patientId);
        
        Task<Appointment> GetAppointmentById([FromQuery] int patientId);

    }
}

