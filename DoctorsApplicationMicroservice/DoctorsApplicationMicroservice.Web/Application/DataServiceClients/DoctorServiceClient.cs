namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using DoctorsApplicationMicroservice.Web.Application.DataServiceClients;

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
        

        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            const string requestUri = "https://localhost:44393/doctors";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<IEnumerable<DoctorDto>>(responseStream, _options);
        }
        
        public async Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            var requestUri = $"https://localhost:44393/getDoctorById?doctorId={doctorId}";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<IEnumerable<DoctorDto>>(responseStream, _options);
        }

        public async Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            var requestUri = $"https://localhost:44393/getDoctorBySpecializations?certificationType={certificationType}";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<IEnumerable<DoctorDto>>(responseStream, _options);
        }
    }
}
