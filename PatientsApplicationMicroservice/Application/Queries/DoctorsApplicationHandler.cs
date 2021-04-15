namespace PatientsApplicationMicroservice.Application.Queries
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using PatientsApplicationMicroservice.Application.DataServiceClients;
    using PatientsApplicationMicroservice.Application.Dtos;

    public class DoctorsApplicationHandler : IDoctorsApplicationHandler
    {
        private readonly IDoctorsServiceClient doctorsServiceClient;

        public DoctorsApplicationHandler(IDoctorsServiceClient doctorsServiceClient)
        {
            this.doctorsServiceClient = doctorsServiceClient;
        }

       public async Task<IEnumerable<DoctorDto>> GetDoctors()
        {
            return await doctorsServiceClient.GetAllDoctors();
     }
        public async Task<DoctorDto> GetDoctorById(int doctorId)
        {
            return await doctorsServiceClient.GetDoctorById(doctorId);
        }
    }
}
