//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ZsutPw.Patterns.WindowsApplication.Dto;

namespace ZsutPw.Patterns.WindowsApplication.Model
{
    public class NetworkClient : INetwork
    {

        
        private readonly ServiceClient serviceClient;

        public NetworkClient(string serviceHost, int servicePort)
        {
            Debug.Assert(!string.IsNullOrEmpty(serviceHost) && servicePort > 0);

            serviceClient = new ServiceClient(serviceHost, servicePort);
        }
        

        public PatientDto GetPatientById(string patientId)
        {
            var callUri = "patient-data?patientId=" + patientId;

            var patient = serviceClient.CallWebService<PatientDto>(HttpMethod.Get, callUri);

            return patient;
        }

        public DoctorDto GetDoctorById(string doctorId)
        {
            var callUri = "doctor-data?id="+doctorId;

            var doctor = serviceClient.CallWebService<DoctorDto>(HttpMethod.Get, callUri);

            return doctor;
        }


        public AppointmentWithNamesDto[] GetAppointmentsHistoryWithNamesDtoList(string patientId)
        {
            var callUri = "appointments-history?patientId="+patientId;

            var appointmentList = serviceClient.CallWebService<AppointmentWithNamesDto[]>(HttpMethod.Get, callUri);

            return appointmentList;
        }

        
        public AppointmentWithNamesDto[] GetFutureAppointmentWithNamesDtoList(string patientId)
        {
            var callUri = "future-appointments?patientId="+patientId;

            var appointmentList = serviceClient.CallWebService<AppointmentWithNamesDto[]>(HttpMethod.Get, callUri);

            return appointmentList;
        }



        public DoctorDto[] GetDoctorDtoList()
        {
            var callUri = "doctors-data";

            var examinationRoomDoctor = serviceClient.CallWebService<DoctorDto[]>(HttpMethod.Get, callUri);

            return examinationRoomDoctor;
        }
    }
}