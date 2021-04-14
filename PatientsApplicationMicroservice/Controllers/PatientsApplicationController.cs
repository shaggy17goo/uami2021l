using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PatientsApplicationMicroservice.Application.Queries;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Controllers
{
    [ApiController]
    public class PatientsApplicationController
    {
        private readonly ILogger<PatientsApplicationController> logger;
        private readonly IPatientsApplicationHandler patientsApplicationHandler;

        public PatientsApplicationController(ILogger<PatientsApplicationController> logger, IPatientsApplicationHandler patientsApplicationHandler)
        {
            this.logger = logger;
            this.patientsApplicationHandler = patientsApplicationHandler;
        }
        [HttpGet("patients-count")]
        public async Task<int> GetLaboratoryDiagnosticiansDetails()
        {
            return await patientsApplicationHandler.GetPatients();
        }
    }
}
