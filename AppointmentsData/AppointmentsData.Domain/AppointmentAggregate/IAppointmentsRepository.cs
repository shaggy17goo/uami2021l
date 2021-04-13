namespace AppointmentsData.Domain.PatientAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public interface IAppointmentsRepository
    {
        Task<IEnumerable<Appointment>> ListAppointments();
        Task<IEnumerable<Appointment>> ListDoctorAppointments(int doctorId);
        Task<IEnumerable<Appointment>> ListPatientAppointments(int patientId);
        Task<Appointment> GetAppointmentById(int appointmentId);

        void AddAppointmentAsync(Appointment appointment);
        void DeleteAppointmentAsync(int commandAppointmentId);
    }
}
