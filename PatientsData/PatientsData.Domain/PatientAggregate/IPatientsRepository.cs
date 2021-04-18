using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatientsData.Domain.PatientAggregate
{
    public interface IPatientsRepository
    {
        Task<IEnumerable<Patient>> listPatients();
        Task<Patient> GetPatientById(int patientId);
        Task<Patient> GetPatientByPESEL(string PESEL);


        void AddPatientAsync(Patient patient);
        void DeletePatientAsync(int commandPatientId, string commandPesel);
    }
}