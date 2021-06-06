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

using System.Collections.Generic;
using System.ComponentModel;
using Model.Data;

namespace Model
{
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