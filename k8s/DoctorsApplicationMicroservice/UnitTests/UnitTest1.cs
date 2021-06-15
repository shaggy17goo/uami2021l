namespace UnitTests
{
    using NUnit.Framework;
    using DoctorsApplicationMicroservice.Web.Application.Commands.Queries;
    using FakeClients;
    using Moq;

    public class Tests
    {


        private DoctorsApplicationQueriesQueryHandler _queriesHandler;
        [SetUp]
        public void Setup()
        {
            var mockDoctorClient = new Mock<FakeDoctorServiceClient>().Object;
            var mockPatientClient = new Mock<FakePatientServiceClient>().Object;
            var mockAppointmentClient = new Mock<FakeAppointmentServiceClient>().Object;
            _queriesHandler =
                new DoctorsApplicationQueriesQueryHandler(mockDoctorClient, mockPatientClient, mockAppointmentClient);
        }

        [Test]
        public void TestGetPatientById()
        {
            var patient = _queriesHandler.GetPatientById(1);
            Assert.AreEqual(patient.Result.Id,1);
        }
        [Test]
        public void TestGetAppointmentsByDoctorId()
        {
            var appointments = _queriesHandler.GetAppointmentsByDoctorId(1);
            // Manually counted
            Assert.AreEqual(appointments.Result.Count,2);
        }
        [Test]
        public void TestGetPatientsByDoctorId()
        {
            var patients = _queriesHandler.GetPatientsByDoctorId(1);
            // Manually counted
            Assert.AreEqual(patients.Result.Count,2);
        }
    }
}