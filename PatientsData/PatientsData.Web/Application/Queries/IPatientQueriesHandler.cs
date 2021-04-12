using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientsData.Domain.PatientAggregate;
using PatientsData.Web.Application.Commands;

namespace PatientsData.Web.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IPatientQueriesHandler
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<Patient> GetPatientById([FromQuery] int patientId);
        Task<Patient> GetPatientByPESEL([FromQuery] string PESEL);
    }
}

