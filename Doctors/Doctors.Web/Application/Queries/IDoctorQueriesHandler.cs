namespace Doctors.Web.Application
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IDoctorQueriesHandler
    {
        Task<IEnumerable<DoctorDto>> GetAllAsync();
        Task<IEnumerable<DoctorDto>> GetById([FromQuery] int doctorId);
        Task<IEnumerable<DoctorDto>> GetByCertificationType([FromQuery] int certificationType);
    }
}
