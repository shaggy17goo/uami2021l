namespace PatientsApplicationMicroservice.Application.Queries
{
    using System.Threading.Tasks;

    public interface IPatientsApplicationHandler
    {
        Task<int> GetPatients();
    }
}
