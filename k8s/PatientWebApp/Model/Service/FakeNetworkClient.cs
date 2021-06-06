using Model.Data;

namespace Model.Service
{
    public class FakeNetworkClient  : INetwork
    {
        public PatientDto GetPatientById(string patientId)
        {
            return new PatientDto("Imie","Nazwisko");
        }

        public DoctorDto GetDoctorById(string doctorId)
        {
            return new DoctorDto("Imie","Nazwisko");
        }

        public DoctorDto[] GetDoctorDtoList()
        {
            throw new System.NotImplementedException();
        }

        public AppointmentWithNamesDto[] GetAppointmentsHistoryWithNamesDtoList(string patientId)
        {
            throw new System.NotImplementedException();
        }

        public AppointmentWithNamesDto[] GetFutureAppointmentWithNamesDtoList(string patientId)
        {
            throw new System.NotImplementedException();
        }
    }
}