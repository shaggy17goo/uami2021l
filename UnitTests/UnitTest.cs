using Microsoft.Extensions.Logging;
using PatientsApplicationMicroservice.Application.Queries;
using PatientsApplicationMicroservice.Controllers;
using System.Net.Http;
using PatientsApplicationMicroservice.Application.DataServiceClients;

using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Moq;
using Microsoft.AspNetCore.TestHost;

using System.Threading.Tasks;
using Moq.Protected;
using System.Net;
using System.Threading;
using System.Web.Http;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
         ILogger<PatientsApplicationController> logger = Mock.Of<ILogger<PatientsApplicationController>>();
         Mock<IHttpClientFactory> mockFactory = new Mock<IHttpClientFactory>();
         Mock<HttpMessageHandler> mockHttpMessageHandler = new Mock<HttpMessageHandler>();


        [TestMethod]
        [Timeout(600000)]
        public void  TestGetDoctors()
        {
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("[{\"id\":69,\"pesel\":\"82914619641\",\"name\":\"Hall\",\"surname\":\"Espinoza\",\"sex\":\"M\",\"birthDate\":\"1969-12-31T04:12:00\",\"city\":\"Nancy\",\"street\":\"826 - 946 Augue.Rd.\",\"houseNr\":\"93\",\"certifications\":[6,3]}, {\"id\":10,\"pesel\":\"47997383838\",\"name\":\"Iris\",\"surname\":\"Patton\",\"sex\":\"M\",\"birthDate\":\"1969-12-31T04:12:00\",\"city\":\"Mayerthorpe\",\"street\":\"P.O.Box 899, 6608 Aliquam St.\",\"houseNr\":\"133\",\"certifications\":[2,8,9,2,6]},{\"id\":11,\"pesel\":\"27880768509\",\"name\":\"Cheryl\",\"surname\":\"Vargas\",\"sex\":\"F\",\"birthDate\":\"1969-12-31T04:12:00\",\"city\":\"Radicofani\",\"street\":\"P.O.Box 284, 6990 Lacus.Rd.\",\"houseNr\":\"38\",\"certifications\":[3,10,5,6,4]},{\"id\":12,\"pesel\":\"49239723988\",\"name\":\"Galena\",\"surname\":\"Bird\",\"sex\":\"M\",\"birthDate\":\"1969-12-31T04:12:00\",\"city\":\"Orilla\",\"street\":\"Ap #632-5836 Dolor. Ave\",\"houseNr\":\"72\",\"certifications\":[5,6,4,5,9,9]},{\"id\":13,\"pesel\":\"10526886186\",\"name\":\"Kasimir\",\"surname\":\"Bowman\",\"sex\":\"M\",\"birthDate\":\"1969-12-31T04:12:00\",\"city\":\"Shahjahanpur\",\"street\":\"Ap #114-180 Sed Street\",\"houseNr\":\"88\",\"certifications\":[8,3]},{\"id\":14,\"pesel\":\"53131873737\",\"name\":\"Abel\",\"surname\":\"Black\",\"sex\":\"M\",\"birthDate\":\"1969-12-31T04:12:00\",\"city\":\"Thurso\",\"street\":\"983-8439 Aliquet, Av.\",\"houseNr\":\"35\",\"certifications\":[2,5,5,4]}]"),
                });

         var client = new HttpClient(mockHttpMessageHandler.Object);
         mockFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(client);
         IAppointmentsServiceClient appointmentsServiceClient = new AppointmentsServiceClient(mockFactory.Object);
         IPatientsServiceClient patientsServiceClient = new PatientsServiceClient(mockFactory.Object);
         IDoctorsServiceClient doctorsServiceClient = new DoctorsServiceClient(mockFactory.Object);
         IPatientsApplicationHandler patientsApplicationHandler = new PatientsApplicationHandler(patientsServiceClient);
         IDoctorsApplicationHandler doctorsApplicationHandler = new DoctorsApplicationHandler(doctorsServiceClient);
         IAppointmentsApplicationHandler appointmentsApplicationHandler= new AppointmentsApplicationHandler(appointmentsServiceClient, patientsServiceClient, doctorsServiceClient);
         var patientsApplicationController = new PatientsApplicationController(logger, patientsApplicationHandler, doctorsApplicationHandler, appointmentsApplicationHandler);
         var result = patientsApplicationController.GetDoctorsData();
         Assert.AreEqual(result.Result.ToList().Count, 6);

        }
        [TestMethod]
        [Timeout(600000)]
        public void TestGetDoctorById()
        {
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{\"id\":9,\"pesel\":\"10801509300\",\"name\":\"Noble\",\"surname\":\"Sweeney\",\"sex\":\"M\",\"birthDate\":\"1969-12-31T04:12:00\",\"city\":\"Biarritz\",\"street\":\"2123 Mauris, Rd.\",\"houseNr\":\"62\",\"certifications\":[1,3,5,7,2,1]}"),
                });

            var client = new HttpClient(mockHttpMessageHandler.Object);
            mockFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(client);
            IAppointmentsServiceClient appointmentsServiceClient = new AppointmentsServiceClient(mockFactory.Object);
            IPatientsServiceClient patientsServiceClient = new PatientsServiceClient(mockFactory.Object);
            IDoctorsServiceClient doctorsServiceClient = new DoctorsServiceClient(mockFactory.Object);
            IPatientsApplicationHandler patientsApplicationHandler = new PatientsApplicationHandler(patientsServiceClient);
            IDoctorsApplicationHandler doctorsApplicationHandler = new DoctorsApplicationHandler(doctorsServiceClient);
            IAppointmentsApplicationHandler appointmentsApplicationHandler = new AppointmentsApplicationHandler(appointmentsServiceClient, patientsServiceClient, doctorsServiceClient);
            var patientsApplicationController = new PatientsApplicationController(logger, patientsApplicationHandler, doctorsApplicationHandler, appointmentsApplicationHandler);
            var result = patientsApplicationController.GetDoctorById(1);
            Assert.AreEqual(result.Result.pesel, "10801509300");
        }

    }
}

              
 
   
 

