namespace PatientsApplicationMicroservice.Application.Queries
{
    using System.Threading.Tasks;

    public interface IDoctorsApplicationHandler
    {
        Task<int> GetDoctors();
    }
}
