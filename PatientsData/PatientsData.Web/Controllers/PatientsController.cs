using PatientsData.Domain.PatientAggregate;

namespace PatientsData.Web.Controllers
{

    using PatientsData.Web.Application;
    using PatientsData.Web.Application.Commands;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ILogger<PatientsController> logger;
        private readonly IPatientQueriesHandler patientQueriesHandler;
        private readonly ICommandHandler<AddPatientCommand> addPatientCommandHandler;
        private readonly ICommandHandler<DeletePatientCommand> deletePatientCommandHandler;

        public PatientsController(ILogger<PatientsController> logger, IPatientQueriesHandler patientQueriesHandler, ICommandHandler<AddPatientCommand> addPatientCommandHandler, ICommandHandler<DeletePatientCommand> deletePatientCommandHandler )
        {
            this.logger = logger;
            this.patientQueriesHandler = patientQueriesHandler;
            this.addPatientCommandHandler = addPatientCommandHandler;
            this.deletePatientCommandHandler = deletePatientCommandHandler;
        }

        [HttpGet("listPatients")]
        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await patientQueriesHandler.GetAllAsync();
        }

        [HttpGet("getPatientById")]
        public async Task<Patient> GetPatientById([FromQuery] int patientId)
        {
            return await patientQueriesHandler.GetPatientById(patientId);
        }
        
        [HttpGet("getPatientByPESEL")]
        public async Task<Patient> GetPatientByPESEL([FromQuery] string PESEL)
        {
            return await patientQueriesHandler.GetPatientByPESEL(PESEL);
        }
        

        [HttpPost("addPatient")]
        public void AddPatient([FromBody] AddPatientCommand patientCommand)
        {
            addPatientCommandHandler.Handle(patientCommand);
        }
        
        [HttpPost("deletePatient")]
        public void DeletePatient([FromBody] DeletePatientCommand patientCommand)
        {
            deletePatientCommandHandler.Handle(patientCommand);
        }
    }
}
