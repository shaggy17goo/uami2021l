namespace Doctors.Domain.DoctorAggregate
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDoctorsRepository
    {
        Task<IEnumerable<Doctor>> GetAllAsync();
        Task<IEnumerable<Doctor>> GetByCertificationType(int certificationType);
        Task<IEnumerable<Doctor>> GetById(int doctorId);
        Task AddDoctorAsync(Doctor doctor);
    }
}
