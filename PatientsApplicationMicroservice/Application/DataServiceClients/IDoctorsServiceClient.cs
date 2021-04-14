using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatientsApplicationMicroservice.Application.Dtos;

namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    public interface IDoctorsServiceClient
    {
        Task<IEnumerable<DoctorDto>> GetAllDoctors();
    }
}
