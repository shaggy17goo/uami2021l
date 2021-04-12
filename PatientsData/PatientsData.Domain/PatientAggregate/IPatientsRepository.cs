namespace PatientsData.Domain.PatientAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public interface IPatientsRepository
    {
        Task<IEnumerable<Patient>> listPatients();
        Task<Patient> GetPatientById(int patientId);
        Task<Patient> GetPatientByPESEL(string PESEL);
        
        
        void AddPatientAsync(Patient patient);
        void DeletePatientAsync(int commandPatientId, string commandPesel);
    }
}
