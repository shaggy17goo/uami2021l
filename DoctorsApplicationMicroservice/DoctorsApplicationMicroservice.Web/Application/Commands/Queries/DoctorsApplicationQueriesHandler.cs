namespace ExaminationRoomsSelector.Web.Application.Queries
{
    using ExaminationRoomsSelector.Web.Application.DataServiceClients;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Dtos;

    public class DoctorsApplicationQueriesQueryHandler : IDoctorsApplicationQueriesHandler
    {
        private readonly IDoctorServiceClient _doctorServiceClient;
        private readonly IPatientServiceClient _patientServiceClient;
        private readonly IAppointmentServiceClient _appointmentServiceClient;


        public DoctorsApplicationQueriesQueryHandler(IDoctorServiceClient doctorServiceClient, IPatientServiceClient patientServiceClient, IAppointmentServiceClient appointmentServiceClient)
        {
            _patientServiceClient = patientServiceClient;
            _doctorServiceClient = doctorServiceClient;
            _appointmentServiceClient = appointmentServiceClient;
        }


        public Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorId(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorIdAndData(int doctorId, DateTime data)
        {
            throw new NotImplementedException();
        }

        public Task<List<PatientsShortDto>> GetPatientsByDoctorId(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<List<PatientDto>> GetPatientById(int patientId)
        {
            throw new NotImplementedException();
        }
    }
}

