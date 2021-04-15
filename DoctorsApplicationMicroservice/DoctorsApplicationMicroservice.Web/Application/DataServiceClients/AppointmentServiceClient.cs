using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ExaminationRoomsSelector.Web.Application.Dtos;

namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    using System.Text.Json;
    using DoctorsApplicationMicroservice.Web.Application.DataServiceClients;

    public class AppointmentServiceClient : IAppointmentServiceClient
    {
        private readonly JsonSerializerOptions _options;
        private readonly GenericServiceClient _serviceClient;

        public AppointmentServiceClient(IHttpClientFactory clientFactory)
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            _serviceClient = new GenericServiceClient(clientFactory);
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