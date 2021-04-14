namespace Doctors.Web.Application.Mapper
{
    using Doctors.Domain.DoctorAggregate;
    using System.Linq;

    public static class Mapper
    {
        public static DoctorDto Map(this Doctor doctor)
        {
            if (doctor == null)
                return null;

            return new DoctorDto
            {
                Id = doctor.Id,
                PESEL = doctor.PESEL,
                Name = doctor.Name,
                Surname = doctor.Surname,
                Sex = doctor.Sex,
                BirthDate = doctor.BirthDate,
                City = doctor.City,
                Street = doctor.Street,
                HouseNr = doctor.HouseNr,
                Certifications = doctor?.Certifications.Select(s => s.Type)
            };
        }
    }
}
