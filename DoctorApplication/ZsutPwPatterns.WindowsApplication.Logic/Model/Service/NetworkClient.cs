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
    using System.Text;

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

        public AppointmentsWithPatientNameDto[] GetAppointmentsByDoctorIdAndData(string doctorId, string date)
        {
            string callUri = String.Format("appointmentsByDoctorIdAndData?doctorId={0}&data={1}", doctorId, date);

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
        public void DeleteAppointment(string appointmentId)
        {
            string callUri = "deleteAppointment";
            string myJson = "{\"appointmentId\":"+appointmentId+"}";
            serviceClient.CallWebService(HttpMethod.Post, callUri, myJson).Wait();
        }
        public void AddAppointment (string doctorId, string patientId, string dateOfAppointment, string description)
        {
            string callUri = "addAppointment";
            string myJson = "{\"doctorId\":" + doctorId + ", \"patientId\":" + patientId + ", \"dateOfAppointment\": \"" + dateOfAppointment + "\", \"description\":\"" + description + "\"}";
            serviceClient.CallWebService(HttpMethod.Post, callUri, myJson).Wait();
        }
        public void AddPatient (string pesel, string name, string surname, string sex, string birthdate, string city, string street, string houseNr)
        {
            string callUri = "addPatient";
            string myJson = "{\"pesel\": \"" + pesel + "\", \"name\":\"" + name + "\", \"surname\":\"" + surname + "\", \"sex\":\"" + sex + "\", \"birthDate\":\"" + birthdate + "\", \"city\":\"" + city + "\", \"street\":\"" + street + "\", \"houseNr\":\"" + houseNr +"\"}";
            serviceClient.CallWebService(HttpMethod.Post, callUri, myJson).Wait();
        }
    }

}
