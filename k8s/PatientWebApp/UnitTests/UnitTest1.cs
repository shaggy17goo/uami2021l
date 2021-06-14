namespace UnitTests
{
    using System.Threading;
    using Controller;
    using Model;
    using Utilities;
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
        public void ConstructorTest()
        {
            Assert.NotNull(Controller);
            Assert.NotNull(Model);
        }
        
        [Test]
        public void TestGetPatientById()
        {
            try
            {
                Controller.Model.SearchText = "9";
                var testTask = Controller.GetPatientByIdAsync();
                Thread.Sleep(3000);
                Assert.AreEqual(Controller.Model.PatientById.Count, 1);
            }
            catch (NotConnectedException ex)
            {
                Assert.Pass(); // the exception should be thrown
            }
            
        }
        
        [Test]
        public void TestGetDoctorById()
        {
            try
            {
                Controller.Model.SearchText = "9";
                var testTask = Controller.GetDoctorByIdAsync();
                Thread.Sleep(3000);
                Assert.AreEqual(Controller.Model.PatientById.Count, 1);
            }
            catch (NotConnectedException ex)
            {
                Assert.Pass(); // the exception should be thrown
            }
            
        }
        
        [Test]
        public void TestGetFutureAppointments()
        {
            try
            {
                Controller.Model.SearchText = "1";
                var testTask = Controller.GetFutureAppointmentsAsync();
                Thread.Sleep(3000);
                Assert.AreEqual(Controller.Model.PatientById.Count, 1);
            }
            catch (NotConnectedException ex)
            {
                Assert.Pass(); // the exception should be thrown
            }
            
        }
        
        [Test]
        public void TestGetAppointmentsHistory()
        {
            try
            {
                Controller.Model.SearchText = "1";
                var testTask = Controller.GetAppointmentsHistoryAsync();
                Thread.Sleep(3000);
                Assert.AreEqual(Controller.Model.PatientById.Count, 1);
            }
            catch (NotConnectedException ex)
            {
                Assert.Pass(); // the exception should be thrown
            }
            
        }
        
        
        
    }
}