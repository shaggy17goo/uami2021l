namespace Model.Service
{
    using System.Collections.Generic;
    using Data;
    public interface INetwork
    {
        PatientDto GetPatientById(string patientId);
        
        DoctorDto GetDoctorById(string doctorId);
        
        IEnumerable<DoctorDto> GetDoctorDtoList();
        
        IEnumerable<AppointmentWithNamesDto> GetAppointmentsHistoryWithNamesDtoList(string patientId);
        
        IEnumerable<AppointmentWithNamesDto> GetFutureAppointmentWithNamesDtoList(string patientId);



    }
}