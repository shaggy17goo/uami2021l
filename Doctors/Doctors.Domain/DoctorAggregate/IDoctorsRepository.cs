namespace Doctors.Domain.DoctorAggregate
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDoctorsRepository
    {
        Task<IEnumerable<Doctor>> GetAllAsync();
        Task<IEnumerable<Doctor>> GetByCertificationType(int certificationType);
        Task<Doctor> GetById(int doctorId);
        Task AddDoctorAsync(Doctor doctor);
        void DeleteDoctorById(int doctorId);
        void DeleteCertificationById(int doctorId);
    }
}
