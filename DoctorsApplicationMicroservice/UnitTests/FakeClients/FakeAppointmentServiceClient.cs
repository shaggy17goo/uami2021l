namespace UnitTests.FakeClients
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DoctorsApplicationMicroservice.Web.Application.Commands.Commands;
    using DoctorsApplicationMicroservice.Web.Application.DataServiceClients;
    using DoctorsApplicationMicroservice.Web.Application.Dtos;
    using FakeRepositories;

    public class FakeAppointmentServiceClient : IAppointmentServiceClient
    {
        public Task<IEnumerable<AppointmentDto>> GetAllAsync()
        {
            var fakeRepo = new TestAppointmentRepository();
            return fakeRepo.GetAppointmentsAsync();
        }

        public Task<IEnumerable<AppointmentDto>> GetAppointmentByDoctorId(int doctorId)
        {
            var fakeRepo = new TestAppointmentRepository();
            var doctors = fakeRepo.GetAppointmentsAsync();
            var result = doctors.Result.Where(appointment => appointment.DoctorId == doctorId).ToList();
            return Task.FromResult((IEnumerable<AppointmentDto>) result);
        }

        public Task<IEnumerable<AppointmentDto>> GetAppointmentByPatientId(int patientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<AppointmentDto> GetAppointmentById(int appointmentId)
        {
            var fakeRepo = new TestAppointmentRepository();
            var doctors = fakeRepo.GetAppointmentsAsync();
            return (from appointment in doctors.Result
                where appointment.AppointmentId == appointmentId
                select Task.FromResult(appointment)).FirstOrDefault();
        }

        public int AddAppointment(AddAppointmentCommand addAppointmentCommand)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteAppointment(DeleteAppointmentCommand deleteAppointmentCommand)
        {
            throw new System.NotImplementedException();
        }
    }
}