namespace ExaminationRoomsSelector.Web.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Dtos;

    public interface IDoctorsApplicationQueriesHandler
    {
        public Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorId(int doctorId);

        public Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorIdAndData(int doctorId, DateTime data);

        public Task<List<PatientsShortDto>> GetPatientsByDoctorId(int doctorId);

        public Task<PatientDto> GetPatientById(int patientId);


    }
}