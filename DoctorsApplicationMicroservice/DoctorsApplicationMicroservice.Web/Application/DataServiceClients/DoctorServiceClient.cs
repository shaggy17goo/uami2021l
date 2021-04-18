using DoctorsApplicationMicroservice.Web.Application.Commands.Commands;

namespace DoctorsApplicationMicroservice.Web.Application.DataServiceClients
{
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
        

        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            const string requestUri = "https://localhost:44393/doctors";

            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }
        
        public async Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            var requestUri = $"https://localhost:44393/getDoctorById?doctorId={doctorId}";

            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }

        public async Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            var requestUri = $"https://localhost:44393/getDoctorBySpecializations?certificationType={certificationType}";

            return await _serviceClient.GetData<IEnumerable<DoctorDto>>(requestUri);
        }

        public void DeleteDoctor(DeleteDoctorCommand deleteDoctorCommand)
        {
            const string url = "https://localhost:44393/doctor-delete";
            _serviceClient.PostData(url, deleteDoctorCommand);
        }
    }
}
