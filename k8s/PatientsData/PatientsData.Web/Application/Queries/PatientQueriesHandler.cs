namespace PatientsData.Web.Application.Queries
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.PatientAggregate;

    public class PatientQueriesHandler : IPatientQueriesHandler
    {
        private readonly IPatientsRepository _patientsRepository;

        public PatientQueriesHandler(IPatientsRepository patientsRepository)
        {
            _patientsRepository = patientsRepository;
        }

        public Task<IEnumerable<Patient>> GetAllAsync()
        {
            return _patientsRepository.listPatients();
        }

        public Task<Patient> GetPatientById(int patientId)
        {
            return _patientsRepository.GetPatientById(patientId);
        }

        public Task<Patient> GetPatientByPESEL(string PESEL)
        {
            return _patientsRepository.GetPatientByPESEL(PESEL);
        }
    }
}