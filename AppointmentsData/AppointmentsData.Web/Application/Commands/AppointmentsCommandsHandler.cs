using AppointmentsData.Domain.PatientAggregate;

namespace AppointmentsData.Web.Application.Commands
{
    //"handler" komendy tworzenia gabinetu
    public class AppointmentsCommandsHandler : ICommandHandler<AddAppointmentCommand>,
        ICommandHandler<DeleteAppointmentCommand>
    {
        private readonly IAppointmentsRepository _appointmentsRepository;

        public AppointmentsCommandsHandler(IAppointmentsRepository appointmentsRepository)
        {
            _appointmentsRepository = appointmentsRepository;
        }

        public int Handle(AddAppointmentCommand command)
        {
            return _appointmentsRepository.AddAppointmentAsync(new Appointment(0, command.DoctorId, command.PatientId,
                command.DateOfAppointment,
                command.Description));
        }

        public int Handle(DeleteAppointmentCommand command)
        {
            return _appointmentsRepository.DeleteAppointmentAsync(command.AppointmentId);
        }
    }
}