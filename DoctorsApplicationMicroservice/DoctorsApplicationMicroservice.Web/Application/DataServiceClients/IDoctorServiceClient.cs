using Microsoft.AspNetCore.Mvc;

namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public interface IDoctorServiceClient
    {
        Task<IEnumerable<DoctorDto>> GetAllAsync();
        
        Task<IEnumerable<DoctorDto>> GetById([FromQuery] int doctorId);
        
        Task<IEnumerable<DoctorDto>> GetByCertificationType([FromQuery] int certificationType);

        }
    }
