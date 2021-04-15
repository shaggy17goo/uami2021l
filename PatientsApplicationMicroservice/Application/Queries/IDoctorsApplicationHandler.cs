namespace PatientsApplicationMicroservice.Application.Queries
{
    using PatientsApplicationMicroservice.Application.Dtos;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDoctorsApplicationHandler
    {
        Task<IEnumerable<DoctorDto>> GetDoctors();
        Task<DoctorDto> GetDoctorById(int doctorId);
    }
}
