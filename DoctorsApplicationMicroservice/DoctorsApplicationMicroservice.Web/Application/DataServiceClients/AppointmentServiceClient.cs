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


        public async Task<IEnumerable<AppointmentDto>> GetAllAsync()
        {
            const string requestUri = "https://localhost:44392/listAppointments";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<IEnumerable<AppointmentDto>>(responseStream, _options);
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentByDoctorId(int doctorId)
        {
            var requestUri = $"https://localhost:44392/getAppointmentByDoctorId?doctorId={doctorId}";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<IEnumerable<AppointmentDto>>(responseStream, _options);
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentByPatientId(int patientId)
        {
            var requestUri = $"https://localhost:44392/getAppointmentByPatientId?patientId={patientId}";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<IEnumerable<AppointmentDto>>(responseStream, _options);
        }

        public async Task<AppointmentDto> GetAppointmentById(int appointmentId)
        {
            var requestUri = $"https://localhost:44392/getAppointmentById?appointmentId={appointmentId}";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<AppointmentDto>(responseStream, _options);
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