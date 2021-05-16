namespace Doctors.Web.Controllers
{
    using Doctors.Web.Application;
    using Doctors.Web.Application.Commands;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly ILogger<DoctorsController> logger;
        private readonly IDoctorQueriesHandler doctorQueriesHandler;
        private readonly ICommandHandler<AddDoctorCommand> addDoctorCommandHandler;
        private readonly ICommandHandler<DeleteDoctorCommand> deleteDoctorCommandHandler;

        public DoctorsController(ILogger<DoctorsController> logger, IDoctorQueriesHandler doctorQueriesHandler, ICommandHandler<AddDoctorCommand> addDoctorCommandHandler, ICommandHandler<DeleteDoctorCommand> deleteDoctorCommandHandler)
        {
            this.logger = logger;
            this.doctorQueriesHandler = doctorQueriesHandler;
            this.addDoctorCommandHandler = addDoctorCommandHandler;
            this.deleteDoctorCommandHandler = deleteDoctorCommandHandler;
    }

        [HttpGet("doctors")]
        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            return await doctorQueriesHandler.GetAllAsync();
        }

        [HttpGet("getDoctorBySpecializations")]
        public Task<IEnumerable<DoctorDto>> GetBySpecialization([FromQuery] int certificationType)
        {
            return doctorQueriesHandler.GetByCertificationType(certificationType);
        }

        [HttpGet("getDoctorById")]
        public async Task<DoctorDto> GetById([FromQuery] int doctorId)
        {
            return await doctorQueriesHandler.GetById(doctorId);
        }

        [HttpPost("doctor")]
        public void AddDoctor([FromBody] AddDoctorCommand doctorCommand)
        {
            addDoctorCommandHandler.Handle(doctorCommand);
        }

        [HttpPost("doctor-delete")]
        public void DeleteDoctor([FromQuery] DeleteDoctorCommand deleteDoctorCommand)
        {
            deleteDoctorCommandHandler.Handle(deleteDoctorCommand);
        }
    }
}

