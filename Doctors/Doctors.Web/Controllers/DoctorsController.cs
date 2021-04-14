namespace Doctors.Web.Controllers
{

    using Doctors.Web.Application;
    using Doctors.Web.Application.Commands;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly ILogger<DoctorsController> logger;
        private readonly IDoctorQueriesHandler doctorQueriesHandler;
        private readonly ICommandHandler<AddDoctorCommand> addDoctorCommandHandler;

        public DoctorsController(ILogger<DoctorsController> logger, IDoctorQueriesHandler doctorQueriesHandler, ICommandHandler<AddDoctorCommand> addDoctorCommandHandler)
        {
            this.logger = logger;
            this.doctorQueriesHandler = doctorQueriesHandler;
            this.addDoctorCommandHandler = addDoctorCommandHandler;
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
        public async Task<IEnumerable<DoctorDto>> GetById([FromQuery] int doctorId)
        {
            return await doctorQueriesHandler.GetById(doctorId);
        }
        [HttpPost("doctor")]
        public void AddExaminationRoom([FromBody] AddDoctorCommand doctorCommand)
        {
            addDoctorCommandHandler.Handle(doctorCommand);
        }
    }
}
