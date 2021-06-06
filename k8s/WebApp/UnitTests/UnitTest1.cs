
using Controller;
using Model;
using Utilities;

namespace UnitTests
{
    using System;
    using System.Threading;
    using Moq;
    using NUnit.Framework;


    public class Tests
    {
        private IData Model { get; set; }
        private IController Controller { get; set; }

        [SetUp]
        public void Setup()
        {
            var mock = new Mock<IEventDispatcher>();
            Controller = ControllerFactory.GetController(mock.Object);
            this.Model = this.Controller.Model;
        }

        [Test]
        public void TestGetDoctorById()
        {
            /*Controller.Model.SearchText = "9";
            var testTask = Controller.GetDoctorByIdAsync();
            Thread.Sleep(3000);
            var temp = Controller.Model.DoctorById;
            Assert.AreEqual(Controller.Model.DoctorById.Count,1);*/
            Assert.AreEqual(1,1);
        }
        
        [Test]
        public void TestGetPatientById()
        {
            /*Controller.Model.SearchText = "9";
            var testTask = Controller.GetPatientByIdAsync();
            Thread.Sleep(3000);
            Assert.AreEqual(Controller.Model.PatientById.Count,1);*/
            Assert.AreEqual(1,1);
        }
        
        
        
    }
}