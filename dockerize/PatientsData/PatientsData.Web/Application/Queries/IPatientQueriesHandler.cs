using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientsData.Domain.PatientAggregate;

namespace PatientsData.Web.Application
{
    public interface IPatientQueriesHandler
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<Patient> GetPatientById([FromQuery] int patientId);
        Task<Patient> GetPatientByPESEL([FromQuery] string PESEL);
    }
}