using PatientsApplicationMicroservice.Application.DataServiceClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Application.Queries
{
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
