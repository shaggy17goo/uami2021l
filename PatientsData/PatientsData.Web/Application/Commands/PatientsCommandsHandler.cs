﻿using PatientsData.Domain.PatientAggregate;

namespace PatientsData.Web.Application.Commands
{
    //"handler" komendy tworzenia gabinetu
    public class PatientsCommandsHandler : ICommandHandler<AddPatientCommand>, ICommandHandler<DeletePatientCommand>
    {
        private readonly IPatientsRepository _patientsRepository;

        public PatientsCommandsHandler(IPatientsRepository patientsRepository)
        {
            _patientsRepository = patientsRepository;
        }

        public void Handle(AddPatientCommand command)
        {
            _patientsRepository.AddPatientAsync(new Patient(0, command.PESEL, command.name, command.surname,
                command.sex, command.birthDate, command.city, command.street, command.houseNr));
        }

        public void Handle(DeletePatientCommand command)
        {
            _patientsRepository.DeletePatientAsync(command.patientId, command.PESEL);
        }
    }
}