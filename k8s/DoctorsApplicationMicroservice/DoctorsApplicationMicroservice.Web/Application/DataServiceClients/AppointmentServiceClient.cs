namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Commands.Commands;
    using Dtos;

    public class AppointmentServiceClient : IAppointmentServiceClient
    {
        private readonly GenericServiceClient _serviceClient;
        public string Host;


        public AppointmentServiceClient(IHttpClientFactory clientFactory)
        {
            _serviceClient = new GenericServiceClient(clientFactory);
            Host = Environment.GetEnvironmentVariable("APPOINTMENTS_HOST");
        }


        public async Task<IEnumerable<AppointmentDto>> GetAllAsync()
        {
            string requestUri = string.Format("{0}listAppointments", Host);

            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
            
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentByDoctorId(int doctorId)
        {
            string requestUri = string.Format("{0}getAppointmentByDoctorId?doctorId={1}", Host, doctorId);
            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentByPatientId(int patientId)
        {
            string requestUri = string.Format("{0}getAppointmentByPatientId?patientId={1}", Host, patientId);
            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
        }

        public async Task<AppointmentDto> GetAppointmentById(int appointmentId)
        {
            string requestUri = string.Format("{0}getAppointmentById?appointmentId={1}", Host, appointmentId);
            return await _serviceClient.GetData<AppointmentDto>(requestUri);
        }

        public int AddAppointment(AddAppointmentCommand addAppointmentCommand)
        {
            string url = string.Format("{0}addAppointment", Host);
            return _serviceClient.PostData(url, addAppointmentCommand);
        }

        public int DeleteAppointment(DeleteAppointmentCommand deleteAppointmentCommand)
        {
            string url = string.Format("{0}deleteAppointment", Host);
            return _serviceClient.PostData(url, deleteAppointmentCommand);
        }
    }
}