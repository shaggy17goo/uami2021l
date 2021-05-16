using NUnit.Framework;

namespace UnitTests
{
    using System;
    using System.Linq;
    using System.Threading;
    using Microsoft.Extensions.Logging;
    using Moq;
    using PatientsData.Domain.PatientAggregate;
    using PatientsData.Infrastructure;
    using PatientsData.Web.Application;
    using PatientsData.Web.Application.Commands;
    using PatientsData.Web.Controllers;

    public class Tests
    {

        private PatientsRepository patientsRepository;
        
        [SetUp]
        public void Setup()
        {
            patientsRepository = new PatientsRepository();
        }

        [Test]
        public void TestListPatients()
        {
            var listPatientsTask = patientsRepository.listPatients();
            Thread.Sleep(3000);
            var taskResult = listPatientsTask.Result;
            Assert.True(taskResult.Any());
        }

        [Test]
        public void TestAddGetAndDelete()
        {
            var tempPatient = new Patient(0, "0000000000000", "Name", "Surname", "M", DateTime.Now, "City", "Street",
                "houseNr");
            var addPatient = patientsRepository.AddPatientAsync(tempPatient);
            Thread.Sleep(3000);
            Assert.True(addPatient > 0);
            var getPatientTask = patientsRepository.GetPatientByPESEL("0000000000000");
            Thread.Sleep(3000);
            var taskResult = getPatientTask.Result;
            Assert.NotNull(taskResult);
            var deletePatient = patientsRepository.DeletePatientAsync(taskResult.patientId, taskResult.PESEL);
            Thread.Sleep(3000);
            Assert.AreEqual(deletePatient, 0);
        }
    }
}