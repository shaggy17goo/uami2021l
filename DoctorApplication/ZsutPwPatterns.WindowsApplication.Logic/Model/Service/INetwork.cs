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
  using System.Diagnostics;
  using System.Linq;
  using System.Threading.Tasks;
  using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public interface INetwork
  {
    AppointmentsWithPatientNameDto[ ] GetAppointmentsByDoctorId( string doctorId );
    AppointmentsWithPatientNameDto[] GetAppointmentsByDoctorIdAndData(string doctorId, string data);
    PatientsShortDto[] GetPatientsByDoctorId(string doctorId);
    PatientDto GetPatientById(string patientId);
  }
}
