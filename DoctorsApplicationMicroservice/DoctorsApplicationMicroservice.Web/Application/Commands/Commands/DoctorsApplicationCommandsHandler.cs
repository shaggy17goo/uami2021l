using System.Net.Http;
using System.Text;
using ExaminationRoomsSelector.Web.Application.DataServiceClients;
using Newtonsoft.Json;

namespace PatientsData.Web.Application.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //"handler" komendy tworzenia gabinetu
    public class DoctorsApplicationCommandsHandler : ICommandHandler<AddPatientCommand>, ICommandHandler<DeleteAppointmentCommand>, ICommandHandler<AddAppointmentCommand>, ICommandHandler<PierdolTeRoboteCommand>
    {
        private readonly IDoctorServiceClient _doctorServiceClient;
        private readonly IPatientServiceClient _patientServiceClient;
        private readonly IAppointmentServiceClient _appointmentServiceClient;
        
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

        public void Handle(PierdolTeRoboteCommand command)
        {
            throw new NotImplementedException();
        }
    }
}