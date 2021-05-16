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

        public AppointmentServiceClient(IHttpClientFactory clientFactory)
        {
            _serviceClient = new GenericServiceClient(clientFactory);
        }

        const string host = "http://appointments_data:80/";

        public async Task<IEnumerable<AppointmentDto>> GetAllAsync()
        {
            string requestUri = String.Format("{0}listAppointments", host);

            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
            
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentByDoctorId(int doctorId)
        {
            string requestUri = String.Format("{0}getAppointmentByDoctorId?doctorId={1}", host,doctorId);

            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
        }

        public async Task<IEnumerable<AppointmentDto>> GetAppointmentByPatientId(int patientId)
        {
            string requestUri = String.Format("{0}getAppointmentByPatientId?patientId={1}", host,patientId);

            return await _serviceClient.GetData<IEnumerable<AppointmentDto>>(requestUri);
        }

        public async Task<AppointmentDto> GetAppointmentById(int appointmentId)
        {
            string requestUri = String.Format("{0}getAppointmentById?appointmentId={1}", host, appointmentId);

            return await _serviceClient.GetData<AppointmentDto>(requestUri);
        }

        public int AddAppointment(AddAppointmentCommand addAppointmentCommand)
        {
            string requestUri = String.Format("{0}addAppointment", host);

            return _serviceClient.PostData(requestUri, addAppointmentCommand);
        }

        public int DeleteAppointment(DeleteAppointmentCommand deleteAppointmentCommand)
        {
            string requestUri = String.Format("{0}deleteAppointment", host);
            return _serviceClient.PostData(requestUri, deleteAppointmentCommand);
        }
    }
}