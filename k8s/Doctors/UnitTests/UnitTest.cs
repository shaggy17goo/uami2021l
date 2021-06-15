using Microsoft.VisualStudio.TestTools.UnitTesting;
using Doctors.Web.Application;
using Doctors.Infrastructure;
using System.Linq;
using Doctors.Web.Application.Commands;
using Microsoft.Extensions.Logging;
using Doctors.Web.Controllers;
using Moq;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        DoctorQueriesHandler doctorQueriesHandler = new DoctorQueriesHandler(new DoctorsRepository());
        ILogger<DoctorsController> logger = Mock.Of<ILogger<DoctorsController>>();
        ICommandHandler<AddDoctorCommand> addDoctorCommandHandler = Mock.Of<ICommandHandler<AddDoctorCommand>>();
        ICommandHandler<DeleteDoctorCommand> deleteDoctorCommandHandler = Mock.Of<ICommandHandler<DeleteDoctorCommand>>();
        [TestMethod]
        [Timeout(600000)]
        public void TestGetById_AssertTrue()
        {

            var doctorsController = new DoctorsController(logger, doctorQueriesHandler, addDoctorCommandHandler, deleteDoctorCommandHandler);
            var tmp = doctorsController.GetById(9);
            Assert.AreEqual(tmp.Result.PESEL, "10801509300");

        }

        [TestMethod]
        [Timeout(600000)]
        public void TestGetAllAsync_AssertTrue()
        {
           
            var doctorsController = new DoctorsController(logger, doctorQueriesHandler, addDoctorCommandHandler, deleteDoctorCommandHandler);
            var tmp = doctorsController.GetAllAsync();
            Assert.AreEqual(tmp.Result.ToList().Count, 101);
        }
    }
}
