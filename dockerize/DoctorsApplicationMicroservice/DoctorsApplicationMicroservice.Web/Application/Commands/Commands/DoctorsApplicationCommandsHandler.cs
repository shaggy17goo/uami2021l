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

        public int Handle(AddPatientCommand command)
        {
            return _patientServiceClient.AddPatient(command);
        }
        
        public int Handle(DeleteAppointmentCommand command)
        {
            return _appointmentServiceClient.DeleteAppointment(command);        }

        public int Handle(AddAppointmentCommand command)
        {
            return _appointmentServiceClient.AddAppointment(command);
        }

        public int Handle(DeleteDoctorCommand command)
        {
            throw new NotImplementedException();
        }

        public int Handle(DeletePatientCommand command)
        {
            throw new NotImplementedException();
        }
    }
}