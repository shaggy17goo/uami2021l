
using System.Collections.Generic;
using System.Threading.Tasks;
using PatientsApplicationMicroservice.Application.Dtos;
namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    public interface IPatientsServiceClient 
    {
        Task<IEnumerable<PatientDto>> GetAllPatients();
    }
}
