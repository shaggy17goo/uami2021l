using PatientsApplicationMicroservice.Application.DataServiceClients;
using PatientsApplicationMicroservice.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Application.Queries
{
    public class AppointmentsApplicationHandler : IAppointmentsApplicationHandler
    {
        private readonly IAppointmentsServiceClient appointmentsServiceClient;
        private readonly IPatientsServiceClient patientsServiceClient;
        private readonly IDoctorsServiceClient doctorsServiceClient;

        public AppointmentsApplicationHandler(IAppointmentsServiceClient appointmentsServiceClient, IPatientsServiceClient patientsServiceClient, IDoctorsServiceClient doctorsServiceClient)
        {
            this.appointmentsServiceClient = appointmentsServiceClient;
            this.patientsServiceClient = patientsServiceClient;
            this.doctorsServiceClient = doctorsServiceClient;
        }

        public async Task<List<AppointmentWithNamesDto>> GetAppointmentsHistory(int patientId)
        { 
            var appointments = await appointmentsServiceClient.GetAppointmentsByPatientId(patientId);
            List<AppointmentWithNamesDto> appointmentsWithNames = new();
            foreach (var appointment in appointments)
            {
                if (DateTime.Compare(appointment.dateOfAppointment, DateTime.Now) == -1)
                {
                    var patient = await patientsServiceClient.GetPatientById(appointment.patientId);
                    var doctor = await doctorsServiceClient.GetDoctorById(appointment.doctorId);
                    appointmentsWithNames.Add(new AppointmentWithNamesDto(appointment.appointmentId, doctor.name, doctor.surname, patient.name, patient.surname, appointment.dateOfAppointment, appointment.description));
                }
        }
            return appointmentsWithNames;
        }
        public async Task<List<AppointmentWithNamesDto>> GetFutureAppointments(int patientId)
        {
            var appointments = await appointmentsServiceClient.GetAppointmentsByPatientId(patientId);
            List<AppointmentWithNamesDto> appointmentsWithNames = new();
            foreach (var appointment in appointments)
            {
                if (DateTime.Compare(appointment.dateOfAppointment, DateTime.Now) == 1)
                {
                    var patient = await patientsServiceClient.GetPatientById(appointment.patientId);
                    var doctor = await doctorsServiceClient.GetDoctorById(appointment.doctorId);
                    appointmentsWithNames.Add(new AppointmentWithNamesDto(appointment.appointmentId, doctor.name, doctor.surname, patient.name, patient.surname, appointment.dateOfAppointment, appointment.description));
                }
            }
            return appointmentsWithNames;
        }
    }
}
