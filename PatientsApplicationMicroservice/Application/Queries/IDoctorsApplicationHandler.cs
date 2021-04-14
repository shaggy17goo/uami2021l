using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Application.Queries
{
    public interface IDoctorsApplicationHandler
    {
        Task<int> GetDoctors();
    }
}
