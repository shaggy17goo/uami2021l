using Model.Data;

namespace Model.Service
{
    using System.Collections.Generic;

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

        public IEnumerable<DoctorDto> GetDoctorDtoList()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AppointmentWithNamesDto> GetAppointmentsHistoryWithNamesDtoList(string patientId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AppointmentWithNamesDto> GetFutureAppointmentWithNamesDtoList(string patientId)
        {
            throw new System.NotImplementedException();
        }
    }
}