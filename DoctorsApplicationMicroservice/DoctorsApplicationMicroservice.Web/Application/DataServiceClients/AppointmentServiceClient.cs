using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ExaminationRoomsSelector.Web.Application.Dtos;

namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    public class AppointmentServiceClient : IAppointmentServiceClient
    {
        public readonly IHttpClientFactory ClientFactory;

        public AppointmentServiceClient(IHttpClientFactory clientFactory)
        {
            ClientFactory = clientFactory;
        }


        public Task<IEnumerable<AppointmentDto>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AppointmentDto>> GetAllAppointmentsOfDoctor(int doctorId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AppointmentDto>> GetAllAppointmentsOfPatient(int patientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<AppointmentDto> GetAppointmentById(int patientId)
        {
            throw new System.NotImplementedException();
        }
    }
}