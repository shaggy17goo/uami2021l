using PatientsApplicationMicroservice.Application.DataServiceClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Application.Queries
{
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
