
namespace UnitTests
{
    using System;
    using System.Threading;
    using Moq;
    using NUnit.Framework;
    using ZsutPw.Patterns.WindowsApplication.Controller;
    using ZsutPw.Patterns.WindowsApplication.Model;
    using ZsutPw.Patterns.WindowsApplication.Utilities;

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
            Controller.Model.SearchText = "9";
            var testCommand = Controller.GetDoctorByIdCommand;
            if (testCommand.CanExecute(null))
            {
                testCommand.Execute(null);
            }
            else Assert.Fail();
            Thread.Sleep(3000);
            var temp = Controller.Model.DoctorById;
            Assert.AreEqual(Controller.Model.DoctorById.Count,1);
        }
        
        [Test]
        public void TestGetPatientById()
        {
            Controller.Model.SearchText = "9";
            var testCommand = Controller.GetPatientByIdCommand;
            if (testCommand.CanExecute(null))
            {
                testCommand.Execute(null);
            }
            else Assert.Fail();
            Thread.Sleep(3000);
            Assert.AreEqual(Controller.Model.PatientById.Count,1);
        }
        
        
        
    }
}