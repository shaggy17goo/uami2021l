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

namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using System.Net.Http;
    using ZsutPw.Patterns.WindowsApplication.Model.Data;

    public class NetworkClient : INetwork
    {
        private readonly ServiceClient serviceClient;

        public NetworkClient(string serviceHost, int servicePort)
        {
            Debug.Assert(condition: !String.IsNullOrEmpty(serviceHost) && servicePort > 0);

            this.serviceClient = new ServiceClient(serviceHost, servicePort);
        }

        public AppointmentsWithPatientNameDto[] GetAppointmentsByDoctorId(string doctorId)
        {
            string callUri = String.Format("appointmentsByDoctorId?doctorId={0}", doctorId);

            AppointmentsWithPatientNameDto[] appointments = serviceClient.CallWebService<AppointmentsWithPatientNameDto[ ]>(HttpMethod.Get, callUri);

            return appointments;
        }

        public AppointmentsWithPatientNameDto[] GetAppointmentsByDoctorIdAndData(string doctorId, string data)
        {
            string callUri = String.Format("appointmentsByDoctorIdAndData?doctorId={0}&data={1}", doctorId, data);

            AppointmentsWithPatientNameDto[] appointments = serviceClient.CallWebService<AppointmentsWithPatientNameDto[]>(HttpMethod.Get, callUri);

            return appointments;
        }

        public PatientsShortDto[] GetPatientsByDoctorId(string doctorId)
        {
            string callUri = String.Format("patientsByDoctorId?doctorId={0}", doctorId);

            PatientsShortDto[] patients = serviceClient.CallWebService<PatientsShortDto[]>(HttpMethod.Get, callUri);

            return patients;
        }
        public PatientDto GetPatientById(string patientId)
        {
            string callUri = String.Format("patientById?patientId={0}", patientId);

            PatientDto patient = serviceClient.CallWebService<PatientDto>(HttpMethod.Get, callUri);

            return patient;
        }
    }
}
