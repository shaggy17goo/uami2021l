namespace PatientsData.Web.Application.Commands
{
    using Domain.PatientAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //"handler" komendy tworzenia gabinetu
    public class PatientsCommandsHandler : ICommandHandler<AddPatientCommand>, ICommandHandler<DeletePatientCommand>
    {
        private readonly IPatientsRepository patientsRepository;

        public PatientsCommandsHandler(IPatientsRepository patientsRepository) 
        {
            this.patientsRepository = patientsRepository;
        }

        public void Handle(AddPatientCommand command)
        {
            patientsRepository.AddPatientAsync(new Patient(0,command.PESEL,command.name,command.surname,
                command.sex,command.birthDate,command.city,command.street,command.houseNr));
        }
        
        public void Handle(DeletePatientCommand command)
        {
            patientsRepository.DeletePatientAsync(command.patientId, command.PESEL);
        }
    }
}