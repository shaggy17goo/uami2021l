namespace UnitTests.FakeClients
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DoctorsApplicationMicroservice.Web.Application.Commands.Commands;
    using DoctorsApplicationMicroservice.Web.Application.DataServiceClients;
    using DoctorsApplicationMicroservice.Web.Application.Dtos;
    using FakeRepositories;

    public class FakeDoctorServiceClient : IDoctorServiceClient
    {
        public Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            var fakeRepo = new TestDoctorRepository();
            return fakeRepo.GetDoctorsAsync();
        }

        public Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            var fakeRepo = new TestDoctorRepository();
            var doctors = fakeRepo.GetDoctorsAsync();
            return (from doctor in doctors.Result
                where doctor.Id == doctorId
                select new List<DoctorDto>() {doctor}
                into result
                select Task.FromResult((IEnumerable<DoctorDto>) result)).FirstOrDefault();
        }

        public Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteDoctor(DeleteDoctorCommand deleteDoctorCommand)
        {
            throw new System.NotImplementedException();
        }
    }
}