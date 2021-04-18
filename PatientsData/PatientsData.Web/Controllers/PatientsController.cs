using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PatientsData.Domain.PatientAggregate;
using PatientsData.Web.Application;
using PatientsData.Web.Application.Commands;

namespace PatientsData.Web.Controllers
{
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ICommandHandler<AddPatientCommand> _addPatientCommandHandler;
        private readonly ICommandHandler<DeletePatientCommand> _deletePatientCommandHandler;
        private readonly IPatientQueriesHandler _patientQueriesHandler;
        private readonly ILogger<PatientsController> logger;

        public PatientsController(ILogger<PatientsController> logger, IPatientQueriesHandler patientQueriesHandler,
            ICommandHandler<AddPatientCommand> addPatientCommandHandler,
            ICommandHandler<DeletePatientCommand> deletePatientCommandHandler)
        {
            this.logger = logger;
            _patientQueriesHandler = patientQueriesHandler;
            _addPatientCommandHandler = addPatientCommandHandler;
            _deletePatientCommandHandler = deletePatientCommandHandler;
        }

        [HttpGet("listPatients")]
        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await _patientQueriesHandler.GetAllAsync();
        }

        [HttpGet("getPatientById")]
        public async Task<Patient> GetPatientById([FromQuery] int patientId)
        {
            return await _patientQueriesHandler.GetPatientById(patientId);
        }

        [HttpGet("getPatientByPESEL")]
        public async Task<Patient> GetPatientByPESEL([FromQuery] string PESEL)
        {
            return await _patientQueriesHandler.GetPatientByPESEL(PESEL);
        }


        [HttpPost("addPatient")]
        public int AddPatient([FromBody] AddPatientCommand patientCommand)
        {
            return _addPatientCommandHandler.Handle(patientCommand);
        }

        [HttpPost("deletePatient")]
        public int DeletePatient([FromBody] DeletePatientCommand patientCommand)
        {
            return _deletePatientCommandHandler.Handle(patientCommand);
        }
    }
}