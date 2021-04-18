using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentsData.Domain.PatientAggregate;

namespace AppointmentsData.Web.Application.Queries
{
    public class AppointmentsQueriesHandler : IAppointmentsQueriesHandler
    {
        private readonly IAppointmentsRepository _appointmentsRepository;

        public AppointmentsQueriesHandler(IAppointmentsRepository appointmentsRepository)
        {
            _appointmentsRepository = appointmentsRepository;
        }

        public Task<IEnumerable<Appointment>> GetAllAsync()
        {
            return _appointmentsRepository.ListAppointments();
        }

        public Task<IEnumerable<Appointment>> GetAllAppointmentsOfDoctor(int doctorId)
        {
            return _appointmentsRepository.ListDoctorAppointments(doctorId);
        }

        public Task<IEnumerable<Appointment>> GetAllAppointmentsOfPatient(int patientId)
        {
            return _appointmentsRepository.ListPatientAppointments(patientId);
        }

        public Task<Appointment> GetAppointmentById(int appointmentId)
        {
            return _appointmentsRepository.GetAppointmentById(appointmentId);
        }
    }
}