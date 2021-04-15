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
            const string requestUri = "https://localhost:44392/doctors";

            await using var responseStream = await _serviceClient.GetData(requestUri);

            return await JsonSerializer.DeserializeAsync<IEnumerable<DoctorDto>>(responseStream, _options);
        }
        
        public Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            throw new NotImplementedException();
        }
    }
}
