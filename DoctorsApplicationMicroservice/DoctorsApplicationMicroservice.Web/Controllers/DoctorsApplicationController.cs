namespace DoctorsApplicationMicroservice.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Application.Commands.Commands;
    using Application.Commands.Queries;
    using Application.Dtos;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    public class DoctorsApplicationController : ControllerBase
    {
        private readonly ICommandHandler<AddAppointmentCommand> _addAppointmentCommand;
        private readonly ICommandHandler<AddPatientCommand> _addPatientCommand;
        private readonly ICommandHandler<DeleteAppointmentCommand> _deleteAppointmentCommand;
        private readonly IDoctorsApplicationQueriesHandler _doctorsApplicationQueriesHandler;
        private readonly ILogger<DoctorsApplicationController> _logger;


        public DoctorsApplicationController(ILogger<DoctorsApplicationController> logger, IDoctorsApplicationQueriesHandler doctorsApplicationQueriesHandler, ICommandHandler<AddAppointmentCommand> addAppointmentCommand, ICommandHandler<AddPatientCommand> addPatientCommand, ICommandHandler<DeleteAppointmentCommand> deleteAppointmentCommand)
        {
            _logger = logger;
            _doctorsApplicationQueriesHandler = doctorsApplicationQueriesHandler;
            _addAppointmentCommand = addAppointmentCommand;
            _addPatientCommand = addPatientCommand;
            _deleteAppointmentCommand = deleteAppointmentCommand;
        }

        // GET

        [HttpGet("appointmentsByDoctorId")]
        public async Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorId(int doctorId)
        {
            return await _doctorsApplicationQueriesHandler.GetAppointmentsByDoctorId(doctorId);
        }

        [HttpGet("appointmentsByDoctorIdAndData")]
        public async Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorIdAndData(int doctorId, DateTime data)
        {
            return await _doctorsApplicationQueriesHandler.GetAppointmentsByDoctorIdAndData(doctorId, data);
        }

        [HttpGet("patientsByDoctorId")]
        public async Task<List<PatientsShortDto>> GetPatientsByDoctorId(int doctorId)
        {
            return await _doctorsApplicationQueriesHandler.GetPatientsByDoctorId(doctorId);
        }

        [HttpGet("patientById")]
        public async Task<PatientDto> GetPatientById(int patientId)
        {
            return await _doctorsApplicationQueriesHandler.GetPatientById(patientId);
        }

        // end GET


        // POST

        [HttpPost("addPatient")]
        public void AddPatient([FromBody] AddPatientCommand command)
        {
            _addPatientCommand.Handle(command);
        }


        [HttpPost("addAppointment")]
        public void AddAppointment([FromBody] AddAppointmentCommand command)
        {
            _addAppointmentCommand.Handle(command);

        }

        [HttpPost("deleteAppointment")]
        public void DeleteAppointment([FromBody] DeleteAppointmentCommand command)
        {
            _deleteAppointmentCommand.Handle(command);
        }
    }
}
