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
        public DoctorServiceClient(IHttpClientFactory clientFactory)
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            _serviceClient = new GenericServiceClient(clientFactory);
        }

        const string host = "http://doctors_data:80/";


        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            string requestUri = String.Format("{0}doctors", host);

            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }
        
        public async Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            string requestUri = String.Format("{0}getDoctorById?doctorId={1}", host,doctorId);

            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }

        public async Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            string requestUri = String.Format("{0}getDoctorBySpecializations?certificationType={1}", host, certificationType);

            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }

        public void DeleteDoctor(DeleteDoctorCommand deleteDoctorCommand)
        {
            string requestUri = String.Format("{0}doctor-delete", host);

            _serviceClient.PostData(requestUri, deleteDoctorCommand);
        }
    }
}
