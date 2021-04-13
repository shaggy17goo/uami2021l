

namespace AppointmentsData.Web.Controllers
{
    using AppointmentsData.Domain.PatientAggregate;
    using AppointmentsData.Web.Application.Queries;
    using AppointmentsData.Web.Application.Commands;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ILogger<PatientsController> _logger;
        private readonly IAppointmentsQueriesHandler _appointmentsQueriesHandler;
        private readonly ICommandHandler<AddAppointmentCommand> addAppointmentCommandHandler;
        private readonly ICommandHandler<DeleteAppointmentCommand> deleteAppointmentCommandHandler;

        public PatientsController(ILogger<PatientsController> logger, IAppointmentsQueriesHandler _appointmentsQueriesHandler, ICommandHandler<AddAppointmentCommand> addAppointmentCommandHandler, ICommandHandler<DeleteAppointmentCommand> deleteAppointmentCommandHandler )
        {
            _logger = logger;
            this._appointmentsQueriesHandler = _appointmentsQueriesHandler;
            this.addAppointmentCommandHandler = addAppointmentCommandHandler;
            this.deleteAppointmentCommandHandler = deleteAppointmentCommandHandler;
        }

        [HttpGet("listAppointments")]
        public async Task<IEnumerable<Appointment>> GetAllAsync()
        {
            return await _appointmentsQueriesHandler.GetAllAsync();
        }
        
        [HttpGet("getAppointmentByDoctorId")]
        public async Task<IEnumerable<Appointment>> GetAppointmentByDoctorId([FromQuery] int doctorId)
        {
            return await _appointmentsQueriesHandler.GetAllAppointmentsOfDoctor(doctorId);
        }
        
        [HttpGet("getAppointmentByPatientId")]
        public async Task<IEnumerable<Appointment>> GetAppointmentByPatientId([FromQuery] int patientId)
        {
            return await _appointmentsQueriesHandler.GetAllAppointmentsOfPatient(patientId);
        }

        [HttpGet("getAppointmentById")]
        public async Task<Appointment> GetAppointmentById([FromQuery] int appointmentId)
        {
            return await _appointmentsQueriesHandler.GetAppointmentById(appointmentId);
        }

        [HttpPost("addAppointment")]
        public void AddAppointment([FromBody] AddAppointmentCommand appointmentCommand)
        {
            addAppointmentCommandHandler.Handle(appointmentCommand);
        }
        
        [HttpPost("deleteAppointment")]
        public void DeleteAppointment([FromBody] DeleteAppointmentCommand appointmentCommand)
        {
            deleteAppointmentCommandHandler.Handle(appointmentCommand);
        }
    }
}
