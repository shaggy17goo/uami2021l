using DoctorsApplicationMicroservice.Web.Application.Commands.Commands;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dtos;
    using Microsoft.AspNetCore.Mvc;

    public interface IDoctorServiceClient
    {
        Task<IEnumerable<DoctorDto>> GetAllAsync();
        
        Task<IEnumerable<DoctorDto>> GetById([FromQuery] int doctorId);
        
        Task<IEnumerable<DoctorDto>> GetByCertificationType([FromQuery] int certificationType);
        
        public void DeleteDoctor([FromQuery] DeleteDoctorCommand deleteDoctorCommand);


    }
    }
