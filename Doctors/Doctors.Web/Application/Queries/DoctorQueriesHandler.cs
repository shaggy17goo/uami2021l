namespace Doctors.Web.Application
{
    using Doctors.Domain.DoctorAggregate;
    using Doctors.Web.Application.Mapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class DoctorQueriesHandler : IDoctorQueriesHandler
    {
        private readonly IDoctorsRepository doctorsRepository;

        public DoctorQueriesHandler(IDoctorsRepository doctorsRepository)
        {
            this.doctorsRepository = doctorsRepository;
        }

        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            return (await doctorsRepository.GetAllAsync()).Select(r=>r.Map());
        }
        public async Task<IEnumerable<DoctorDto>> GetById(int doctorId)
        {
            return (await doctorsRepository.GetById(doctorId)).Select(r => r.Map());
        }

        public async Task<IEnumerable<DoctorDto>> GetByCertificationType(int certificationType)
        {
            return (await doctorsRepository.GetByCertificationType(certificationType)).Select(ld=>ld.Map());
        }
    }
}
