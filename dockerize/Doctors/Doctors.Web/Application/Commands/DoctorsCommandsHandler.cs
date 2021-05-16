namespace Doctors.Web.Application.Commands
{
    using Doctors.Domain.DoctorAggregate;
    using System;
    using System.Collections.Generic;

    public class DoctorsCommandsHandler : ICommandHandler<AddDoctorCommand>, ICommandHandler<DeleteDoctorCommand>
    {
        private readonly IDoctorsRepository doctorsRepository;

        public DoctorsCommandsHandler(IDoctorsRepository doctorsRepository) 
        {
            this.doctorsRepository = doctorsRepository;
        }

        public void Handle(AddDoctorCommand command)
        {
            var certifications = new List<Certification>();

            foreach (var certification in command.Certifications)
                certifications.Add(new Certification(0, DateTime.UtcNow, certification));

            doctorsRepository.AddDoctorAsync(new Doctor(0,command.PESEL,command.Name,command.Surname,command.Sex,command.BirthDate,command.City,command.Street,command.HouseNr,certifications));
        }
        public void Handle(DeleteDoctorCommand command)
        {
            doctorsRepository.DeleteDoctorById(command.Id);
            doctorsRepository.DeleteCertificationById(command.Id);
        }
    }
}
