using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppointmentsData.Domain.PatientAggregate
{
    public interface IAppointmentsRepository
    {
        Task<IEnumerable<Appointment>> ListAppointments();
        Task<IEnumerable<Appointment>> ListDoctorAppointments(int doctorId);
        Task<IEnumerable<Appointment>> ListPatientAppointments(int patientId);
        Task<Appointment> GetAppointmentById(int appointmentId);

        public int AddAppointmentAsync(Appointment appointment);
        public int DeleteAppointmentAsync(int commandAppointmentId);
    }
}