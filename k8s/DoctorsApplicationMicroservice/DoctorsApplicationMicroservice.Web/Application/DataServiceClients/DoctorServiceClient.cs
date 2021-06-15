namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
    using DoctorsApplicationMicroservice.Web.Application.Commands.Commands;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Dtos;

    public class DoctorServiceClient : IDoctorServiceClient
    {
        private readonly JsonSerializerOptions _options;
        private readonly GenericServiceClient _serviceClient;
        private readonly string _host;
        public DoctorServiceClient(IHttpClientFactory clientFactory)
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            _serviceClient = new GenericServiceClient(clientFactory);
            _host = Environment.GetEnvironmentVariable("DOCTORS_HOST");
        }
        

        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            var requestUri = $"{_host}doctors";
            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }
        
        public async Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            var requestUri = $"{_host}getDoctorById?doctorId={doctorId}";
            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }

        public async Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            var requestUri = $"{_host}getDoctorBySpecializations?certificationType={certificationType}";
            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }

        public void DeleteDoctor(DeleteDoctorCommand deleteDoctorCommand)
        {
            var url = $"{_host}doctor-delete";
            _serviceClient.PostData(url, deleteDoctorCommand);
        }
    }
}
