namespace UnitTests.FakeClients
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DoctorsApplicationMicroservice.Web.Application.Commands.Commands;
    using DoctorsApplicationMicroservice.Web.Application.DataServiceClients;
    using DoctorsApplicationMicroservice.Web.Application.Dtos;
    using FakeRepositories;

    public class FakePatientServiceClient : IPatientServiceClient
    {
        public Task<IEnumerable<PatientDto>> GetAllAsync()
        {
            var fakeRepo = new TestPatientRepository();
            return fakeRepo.GetPatientsAsync();
        }

        public Task<PatientDto> GetPatientById(int patientId)
        {
            var fakeRepo = new TestPatientRepository();
            var patients = fakeRepo.GetPatientsAsync();
            return (from patient in patients.Result where patient.Id == patientId select Task.FromResult(patient)).FirstOrDefault();
        }

        public Task<PatientDto> GetPatientByPESEL(string pesel)
        {
            throw new System.NotImplementedException();
        }

        public int AddPatient(AddPatientCommand addPatientCommand)
        {
            throw new System.NotImplementedException();
        }

        public int DeletePatient(DeletePatientCommand deletePatientCommand)
        {
            throw new System.NotImplementedException();
        }
    }
}