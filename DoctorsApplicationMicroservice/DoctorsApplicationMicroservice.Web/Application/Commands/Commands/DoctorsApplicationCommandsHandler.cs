namespace DoctorsApplicationMicroservice.Web.Application.Commands.Commands
{
    using System;
    using DataServiceClients;

    //"handler" komendy tworzenia gabinetu
    public class DoctorsApplicationCommandsHandler : ICommandHandler<AddPatientCommand>, ICommandHandler<DeleteAppointmentCommand>, ICommandHandler<AddAppointmentCommand>, ICommandHandler<DeleteDoctorCommand>, ICommandHandler<DeletePatientCommand>
    {
        private readonly IDoctorServiceClient _doctorServiceClient;
        private readonly IPatientServiceClient _patientServiceClient;
        private readonly IAppointmentServiceClient _appointmentServiceClient;

        public DoctorsApplicationCommandsHandler(IDoctorServiceClient doctorServiceClient, IPatientServiceClient patientServiceClient, IAppointmentServiceClient appointmentServiceClient)
        {
            _doctorServiceClient = doctorServiceClient;
            _patientServiceClient = patientServiceClient;
            _appointmentServiceClient = appointmentServiceClient;
        }

        public void Handle(AddPatientCommand command)
        {
            _patientServiceClient.AddPatient(command);
        }
        
        public void Handle(DeleteAppointmentCommand command)
        {
            _appointmentServiceClient.DeleteAppointment(command);        }

        public void Handle(AddAppointmentCommand command)
        {
            _appointmentServiceClient.AddAppointment(command);
        }

        public void Handle(DeleteDoctorCommand command)
        {
            throw new NotImplementedException();
        }

        public void Handle(DeletePatientCommand command)
        {
            throw new NotImplementedException();
        }
    }
}