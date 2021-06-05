namespace PatientsApplicationMicroservice.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using PatientsApplicationMicroservice.Application.Dtos;
    using PatientsApplicationMicroservice.Application.Queries;

    [ApiController]
    public class PatientsApplicationController
    {
        private readonly ILogger<PatientsApplicationController> logger;
        private readonly IPatientsApplicationHandler patientsApplicationHandler;
        private readonly IDoctorsApplicationHandler doctorsApplicationHandler;
        private readonly IAppointmentsApplicationHandler appointmentsApplicationHandler;

        public PatientsApplicationController(ILogger<PatientsApplicationController> logger, IPatientsApplicationHandler patientsApplicationHandler, IDoctorsApplicationHandler doctorsApplicationHandler, IAppointmentsApplicationHandler appointmentsApplicationHandler)
        {
            this.logger = logger;
            this.patientsApplicationHandler = patientsApplicationHandler;
            this.doctorsApplicationHandler = doctorsApplicationHandler;
            this.appointmentsApplicationHandler = appointmentsApplicationHandler;
        }

        [HttpGet("doctors-data")]
        public async Task<IEnumerable<DoctorDto>> GetDoctorsData()
        {
            return await doctorsApplicationHandler.GetDoctors();
        }
        [HttpGet("doctor-data")]
        public async Task<DoctorDto> GetDoctorById(int id)
        {
            return await doctorsApplicationHandler.GetDoctorById(id);
        }

        [HttpGet("patient-data")]
        public async Task<PatientDto> GetPatientData([FromQuery]int patientId)
        {
            return await patientsApplicationHandler.GetPatientById(patientId);
        }
        [HttpGet("appointments-history")]
        public async Task<List<AppointmentWithNamesDto>> GetAppointmentsHistoryByPatientId([FromQuery] int patientId)
        {
            return await appointmentsApplicationHandler.GetAppointmentsHistory(patientId);
        }
        [HttpGet("future-appointments")]
        public async Task<List<AppointmentWithNamesDto>> GetAppointmentsByPatientId([FromQuery] int patientId)
        {
            return await appointmentsApplicationHandler.GetFutureAppointments(patientId);
        }
    }
}
