namespace Model.Service
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net.Http;
    using Data;
    using Utilities;
    public class NetworkClient : INetwork
    {

        
        private readonly ServiceClient _serviceClient;

        public NetworkClient(string serviceHost, int servicePort)
        {
            Debug.Assert(!string.IsNullOrEmpty(serviceHost) && servicePort > 0);

            _serviceClient = new ServiceClient(serviceHost, servicePort);
        }
        

        public PatientDto GetPatientById(string patientId)
        {
            var callUri = "patient-data?patientId=" + patientId;

            var patient = _serviceClient.CallWebService<PatientDto>(HttpMethod.Get, callUri);

            return patient;
        }

        public DoctorDto GetDoctorById(string doctorId)
        {
            var callUri = "doctor-data?id="+doctorId;

            var doctor = _serviceClient.CallWebService<DoctorDto>(HttpMethod.Get, callUri);

            return doctor;
        }


        public IEnumerable<AppointmentWithNamesDto> GetAppointmentsHistoryWithNamesDtoList(string patientId)
        {
            var callUri = "appointments-history?patientId="+patientId;

            var appointmentList = _serviceClient.CallWebService<AppointmentWithNamesDto[]>(HttpMethod.Get, callUri);

            return appointmentList;
        }

        
        public IEnumerable<AppointmentWithNamesDto> GetFutureAppointmentWithNamesDtoList(string patientId)
        {
            var callUri = "future-appointments?patientId="+patientId;

            var appointmentList = _serviceClient.CallWebService<AppointmentWithNamesDto[]>(HttpMethod.Get, callUri);

            return appointmentList;
        }



        public IEnumerable<DoctorDto> GetDoctorDtoList()
        {
            var callUri = "doctors-data";

            var examinationRoomDoctor = _serviceClient.CallWebService<DoctorDto[]>(HttpMethod.Get, callUri);

            return examinationRoomDoctor;
        }
    }
}