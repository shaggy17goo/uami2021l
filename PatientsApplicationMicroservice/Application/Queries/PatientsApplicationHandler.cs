namespace PatientsApplicationMicroservice.Application.Queries
{
    using System.Linq;
    using System.Threading.Tasks;

    using PatientsApplicationMicroservice.Application.DataServiceClients;

    public class PatientsApplicationHandler : IPatientsApplicationHandler
    {
        private readonly IPatientsServiceClient patientsServiceClient;

        public PatientsApplicationHandler(IPatientsServiceClient patientsServiceClient)
        {
            this.patientsServiceClient = patientsServiceClient;
        }

        public async Task<int> GetPatients()
        {
            return (await patientsServiceClient.GetAllPatients()).Count();
        }
    }
}
