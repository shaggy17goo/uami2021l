using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentsData.Domain.PatientAggregate;
using AppointmentsData.Web.Application.Commands;
using AppointmentsData.Web.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppointmentsData.Web.Controllers
{
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ILogger<PatientsController> _logger;
        private readonly IAppointmentsQueriesHandler _appointmentsQueriesHandler;
        private readonly ICommandHandler<AddAppointmentCommand> _addAppointmentCommandHandler;
        private readonly ICommandHandler<DeleteAppointmentCommand> _deleteAppointmentCommandHandler;

        public PatientsController(ILogger<PatientsController> logger,
            IAppointmentsQueriesHandler appointmentsQueriesHandler,
            ICommandHandler<AddAppointmentCommand> addAppointmentCommandHandler,
            ICommandHandler<DeleteAppointmentCommand> deleteAppointmentCommandHandler)
        {
            _logger = logger;
            _appointmentsQueriesHandler = appointmentsQueriesHandler;
            _addAppointmentCommandHandler = addAppointmentCommandHandler;
            _deleteAppointmentCommandHandler = deleteAppointmentCommandHandler;
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
            _addAppointmentCommandHandler.Handle(appointmentCommand);
        }

        [HttpPost("deleteAppointment")]
        public void DeleteAppointment([FromBody] DeleteAppointmentCommand appointmentCommand)
        {
            _deleteAppointmentCommandHandler.Handle(appointmentCommand);
        }
    }
}