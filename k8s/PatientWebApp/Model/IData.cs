namespace Model
{
    
    using System.Collections.Generic;
    using System.ComponentModel;
    using Data;

    public interface IData : INotifyPropertyChanged
    {
        string SearchText { get; set; }

        List<PatientDto> PatientById{ get; }
        
        List<DoctorDto> DoctorById{ get; }
        
        List<AppointmentWithNamesDto> AppointmentsHistoryWithNamesDtoList { get; }

        AppointmentWithNamesDto SelectedAppointmentsHistoryWithNamesDtoDto { get; set; }
        
        List<AppointmentWithNamesDto> FutureAppointmentWithNamesDtoList { get; }

        AppointmentWithNamesDto SelectedFutureAppointmentWithNamesDtoDto { get; set; }
        
        List<DoctorDto> DoctorDtoList { get; }

        DoctorDto SelectedDoctorDto { get; set; }
        
        List<PatientDto> PatientDtoList { get; }

        PatientDto SelectedPatientDto { get; set; }
        
    }
}