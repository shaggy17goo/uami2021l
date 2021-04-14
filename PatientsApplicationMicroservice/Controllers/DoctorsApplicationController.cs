using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PatientsApplicationMicroservice.Application.Queries;

namespace PatientsApplicationMicroservice.Controllers
{
    [ApiController]
    public class DoctorsApplicationController
    {
        private readonly ILogger<DoctorsApplicationController> logger;
        private readonly IDoctorsApplicationHandler doctorsApplicationHandler;

        public DoctorsApplicationController(ILogger<DoctorsApplicationController> logger, IDoctorsApplicationHandler doctorsApplicationHandler)
        {
            this.logger = logger;
            this.doctorsApplicationHandler = doctorsApplicationHandler;
        }
        [HttpGet("doctors-count")]
        public async Task<int> GetLaboratoryDiagnosticiansDetails()
        {
            return await doctorsApplicationHandler.GetDoctors();
        }
    }
}
