namespace Doctors.Web.Application
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDoctorQueriesHandler
    {
        Task<IEnumerable<DoctorDto>> GetAllAsync();
        Task<DoctorDto> GetById([FromQuery] int doctorId);
        Task<IEnumerable<DoctorDto>> GetByCertificationType([FromQuery] int certificationType);
    }
}
