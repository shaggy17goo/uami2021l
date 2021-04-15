namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Commands.Commands;
    using Dtos;

    public class AppointmentServiceClient : IAppointmentServiceClient
    {
        private readonly GenericServiceClient _serviceClient;

        public AppointmentServiceClient(IHttpClientFactory clientFactory)
        {
            _serviceClient = new GenericServiceClient(clientFactory);
        }


        public async Task<IEnumerable<AppointmentDto>> GetAllAsync()
        {
            const string requestUri = "https://localhost:44392/listAppointments";

            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
            
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentByDoctorId(int doctorId)
        {
            var requestUri = $"https://localhost:44392/getAppointmentByDoctorId?doctorId={doctorId}";
            
            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentByPatientId(int patientId)
        {
            var requestUri = $"https://localhost:44392/getAppointmentByPatientId?patientId={patientId}";

            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
        }

        public async Task<AppointmentDto> GetAppointmentById(int appointmentId)
        {
            var requestUri = $"https://localhost:44392/getAppointmentById?appointmentId={appointmentId}";

            return await _serviceClient.GetData<AppointmentDto>(requestUri);
        }

        public void AddAppointment(AddAppointmentCommand addAppointmentCommand)
        {
            const string url = "https://localhost:44392/addAppointment";
            _serviceClient.PostData(url, addAppointmentCommand);
        }

        public void DeleteAppointment(DeleteAppointmentCommand deleteAppointmentCommand)
        {
            const string url = "https://localhost:44392/deleteAppointment";
            _serviceClient.PostData(url, deleteAppointmentCommand);
        }
    }
}