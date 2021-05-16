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
using ZsutPw.Patterns.WindowsApplication.Dto;

namespace ZsutPw.Patterns.WindowsApplication.Model
{
    public interface INetwork
    {
        PatientDto GetPatientById(string patientId);
        
        DoctorDto GetDoctorById(string doctorId);
        
        DoctorDto[] GetDoctorDtoList();
        
        AppointmentWithNamesDto[] GetAppointmentsHistoryWithNamesDtoList(string patientId);
        
        AppointmentWithNamesDto[] GetFutureAppointmentWithNamesDtoList(string patientId);



    }
}