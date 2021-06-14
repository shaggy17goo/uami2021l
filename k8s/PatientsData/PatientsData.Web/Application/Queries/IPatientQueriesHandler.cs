namespace PatientsData.Web.Application.Queries
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.PatientAggregate;
    using Microsoft.AspNetCore.Mvc;

    public interface IPatientQueriesHandler
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<Patient> GetPatientById([FromQuery] int patientId);
        Task<Patient> GetPatientByPESEL([FromQuery] string PESEL);
    }
}