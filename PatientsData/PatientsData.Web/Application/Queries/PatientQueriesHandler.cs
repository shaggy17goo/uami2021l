using System.Collections.Generic;
using System.Threading.Tasks;
using PatientsData.Domain.PatientAggregate;

namespace PatientsData.Web.Application
{
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