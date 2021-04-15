﻿namespace DoctorsApplicationMicroservice.Web.Application.Commands.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DataServiceClients;
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


        public async Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorId(int doctorId)
        {
            var doctorAppointments = await _appointmentServiceClient.GetAppointmentByDoctorId(doctorId);
            var result = new List<AppointmentsWithPatientNameDto>();
            foreach (var aD in doctorAppointments)
            {
                var tempPatientDto = await _patientServiceClient.GetPatientById(aD.patientId);
                result.Add(new AppointmentsWithPatientNameDto(aD.appointmentId, aD.doctorId, aD.patientId,
                    aD.dateOfAppointment, aD.description, tempPatientDto.name, tempPatientDto.surname));
            }

            return result;
        }

        public async Task<List<AppointmentsWithPatientNameDto>> GetAppointmentsByDoctorIdAndData(int doctorId, DateTime data)
        {
            var doctorAppointments = await _appointmentServiceClient.GetAppointmentByDoctorId(doctorId);
            var result = new List<AppointmentsWithPatientNameDto>();
            foreach (var aD in doctorAppointments)
            {
                if (data.Date != aD.dateOfAppointment.Date) continue;
                var tempPatientDto = await _patientServiceClient.GetPatientById(aD.patientId);
                result.Add(new AppointmentsWithPatientNameDto(aD.appointmentId, aD.doctorId, aD.patientId,
                    aD.dateOfAppointment, aD.description, tempPatientDto.name, tempPatientDto.surname));

            }

            return result;
        }

        public async Task<List<PatientsShortDto>> GetPatientsByDoctorId(int doctorId)
        {
            var doctorAppointments = await _appointmentServiceClient.GetAppointmentByDoctorId(doctorId);
            var result = new List<PatientsShortDto>();
            foreach (var aD in doctorAppointments)
            {
                var tempPatientDto = await _patientServiceClient.GetPatientById(aD.patientId);
                result.Add(new PatientsShortDto(tempPatientDto));

            }

            return result;
        }

        public async Task<PatientDto> GetPatientById(int patientId)
        {
            return await _patientServiceClient.GetPatientById(patientId);
        }
    }
}

