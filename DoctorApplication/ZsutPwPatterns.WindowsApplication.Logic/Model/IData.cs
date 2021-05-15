﻿//===============================================================================
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
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  using System.ComponentModel;
    using ZsutPw.Patterns.WindowsApplication.Model.Data;

    public interface IData : INotifyPropertyChanged
  {
    string SearchText { get; set; }
    PatientDto PatientById { get; }
    List<PatientsShortDto> PatientsByDoctorId { get; }
    PatientsShortDto SelectedPatientsByDoctorId { get; set; }
    List<AppointmentsWithPatientNameDto> AppointmentsByDoctorIdAndData { get; }
    AppointmentsWithPatientNameDto SelectedAppointment { get; set; }
    List<AppointmentsWithPatientNameDto> AppointmentsByDoctorId { get; }
  }
}
