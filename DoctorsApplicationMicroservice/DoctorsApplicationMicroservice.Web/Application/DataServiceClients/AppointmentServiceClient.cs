using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ExaminationRoomsSelector.Web.Application.Dtos;
using PatientsData.Web.Application.Commands;

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

        public Task<IEnumerable<AppointmentDto>> GetAppointmentByDoctorId(int doctorId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AppointmentDto>> GetAppointmentByPatientId(int patientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<AppointmentDto> GetAppointmentById(int appointmentId)
        {
            throw new System.NotImplementedException();
        }

        public void AddAppointment(AddAppointmentCommand appointmentCommand)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAppointment(DeleteAppointmentCommand appointmentCommand)
        {
            throw new System.NotImplementedException();
        }
    }
}