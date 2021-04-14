namespace PatientsApplicationMicroservice.Application.Queries
{
    using System.Linq;
    using System.Threading.Tasks;

    using PatientsApplicationMicroservice.Application.DataServiceClients;

    public class DoctorsApplicationHandler : IDoctorsApplicationHandler
    {
        private readonly IDoctorsServiceClient doctorsServiceClient;

        public DoctorsApplicationHandler(IDoctorsServiceClient doctorsServiceClient)
        {
            this.doctorsServiceClient = doctorsServiceClient;
        }

        public async Task<int> GetDoctors()
        {
            return (await doctorsServiceClient.GetAllDoctors()).Count();
        }
    }
}
