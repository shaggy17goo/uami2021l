namespace AppointmentsData.Web.Application.Commands
{
    using Domain.PatientAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //"handler" komendy tworzenia gabinetu
    public class AppointmentsCommandsHandler : ICommandHandler<AddAppointmentCommand>, ICommandHandler<DeleteAppointmentCommand>
    {
        private readonly IAppointmentsRepository _appointmentsRepository;

        public AppointmentsCommandsHandler(IAppointmentsRepository appointmentsRepository) 
        {
            this._appointmentsRepository = appointmentsRepository;
        }

        public void Handle(AddAppointmentCommand command)
        {
            _appointmentsRepository.AddAppointmentAsync(new Appointment(0,command.doctorId,command.patientId,command.dateOfAppointment,
                command.description));
        }
        
        public void Handle(DeleteAppointmentCommand command)
        {
            _appointmentsRepository.DeleteAppointmentAsync(command.appointmentId);
        }
    }
}