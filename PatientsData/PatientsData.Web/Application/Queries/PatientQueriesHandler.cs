namespace PatientsData.Web.Application
{
    using Domain.PatientAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PatientQueriesHandler : IPatientQueriesHandler
    {
        private readonly IPatientsRepository patientsRepository;

        public PatientQueriesHandler(IPatientsRepository patientsRepository)
        {
            this.patientsRepository = patientsRepository;
        }

        public Task<IEnumerable<Patient>> GetAllAsync()
        {
            return patientsRepository.listPatients();
        }

        public Task<Patient> GetPatientById(int patientId)
        {
            return patientsRepository.GetPatientById(patientId);
        }

        public Task<Patient> GetPatientByPESEL(string PESEL)
        {
            return patientsRepository.GetPatientByPESEL(PESEL);
        }
    }
}
