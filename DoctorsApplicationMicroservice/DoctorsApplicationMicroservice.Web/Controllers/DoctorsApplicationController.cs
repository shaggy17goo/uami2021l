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

    [ApiController]
    public class DoctorsApplicationController : ControllerBase
    {
        private readonly ILogger<DoctorsApplicationController> logger;
        private readonly IDoctorsApplicationQueriesHandler _doctorsApplicationQueriesHandler;


        public DoctorsApplicationController(ILogger<DoctorsApplicationController> logger, IDoctorsApplicationQueriesHandler doctorsApplicationQueriesHandler)
        {
            this.logger = logger;
            this._doctorsApplicationQueriesHandler = doctorsApplicationQueriesHandler;
        }

        // GET

        [HttpGet("appointmentsByDoctorId")]
        public async Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorId(int doctorId)
        {
            return null;
            //doctorsApplicationHandler.GetExaminationRoomsSelectionAsync();
        }
 
        [HttpGet("appointmentsByDoctorIdAndData")]
        public async Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorIdAndData(int doctorId, DateTime data)
        {
            return null;
            //doctorsApplicationHandler.GetExaminationRoomsSelectionAsync();
        }
        
        [HttpGet("patientsByDoctorId")]
        public async Task<List<PatientsShortDto>> GetPatientsByDoctorId(int doctorId)
        {
            return null;
            //doctorsApplicationHandler.GetExaminationRoomsSelectionAsync();
        }
        
        [HttpGet("patientById")]
        public async Task<List<PatientDto>> GetPatientById(int patientId)
        {
            return null;
            //doctorsApplicationHandler.GetExaminationRoomsSelectionAsync();
        }
        
        // end GET
        
        
        // POST
        
        [HttpPost("addPatient")]
        public async Task AddPatient([FromBody] PatientDto patientDto)
        {
            //await _doctorsApplicationHandler.addDoctor(doctorAdd);
        }
        
        
        [HttpPost("addAppointment")]
        public async Task AddAppointment([FromBody] AppointmentDto appointmentDto)
        {
            //await _doctorsApplicationHandler.addDoctor(doctorAdd);
        }
        
        [HttpPost("deleteAppointment")]
        public async Task DeleteAppointment([FromBody] int appointmentId)
        {
            //await _doctorsApplicationHandler.addDoctor(doctorAdd);
        }
        
        
        [HttpPost("pierdolTeRobote")]
        public async Task PierdolTeRobote([FromBody] int doctorId)
        {
            //await _doctorsApplicationHandler.addDoctor(doctorAdd);
        }

    }
}
