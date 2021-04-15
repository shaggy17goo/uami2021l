using ExaminationRoomsSelector.Web.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationRoomsSelector.Web.Controllers
{
    using Application.Dtos;
    using PatientsData.Web.Application.Commands;

    [ApiController]
    public class DoctorsApplicationController : ControllerBase
    {
        private readonly ILogger<DoctorsApplicationController> logger;
        private readonly IDoctorsApplicationQueriesHandler _doctorsApplicationQueriesHandler;
        private readonly ICommandHandler<AddAppointmentCommand> _addAppointmentCommand;
        private readonly ICommandHandler<AddPatientCommand> _addPatientCommand;
        private readonly ICommandHandler<DeleteAppointmentCommand> _deleteAppointmentCommand;


        public DoctorsApplicationController(ILogger<DoctorsApplicationController> logger, IDoctorsApplicationQueriesHandler doctorsApplicationQueriesHandler, ICommandHandler<AddAppointmentCommand> addAppointmentCommand, ICommandHandler<AddPatientCommand> addPatientCommand, ICommandHandler<DeleteAppointmentCommand> deleteAppointmentCommand)
        {
            this.logger = logger;
            this._doctorsApplicationQueriesHandler = doctorsApplicationQueriesHandler;
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
        
        
        [HttpPost("pierdolTeRobote")]
        public void DeleteDoctor([FromBody] int doctorId)
        {
            throw new NotImplementedException();
        }

    }
}
