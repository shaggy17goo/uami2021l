using DoctorsApplicationMicroservice.Web.Application.Commands.Commands;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
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
        public string Host;
        public DoctorServiceClient(IHttpClientFactory clientFactory)
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            _serviceClient = new GenericServiceClient(clientFactory);
            Host = Environment.GetEnvironmentVariable("DOCTORS_HOST");
        }
        

        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            string requestUri = string.Format("{0}doctors", Host);
            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }
        
        public async Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            string requestUri = string.Format("{0}getDoctorById?doctorId={1}", Host, doctorId);
            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }

        public async Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            string requestUri = string.Format("{0}getDoctorBySpecializations?certificationType={1}", Host, certificationType);
            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }

        public void DeleteDoctor(DeleteDoctorCommand deleteDoctorCommand)
        {
            string url = string.Format("{0}doctor-delete");
            _serviceClient.PostData(url, deleteDoctorCommand);
        }
    }
}
