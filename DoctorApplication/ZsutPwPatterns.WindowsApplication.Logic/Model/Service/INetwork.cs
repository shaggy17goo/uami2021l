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
  using ZsutPw.Patterns.WindowsApplication.Model.Data;

    public interface INetwork
  {
    AppointmentsWithPatientNameDto[] GetAppointmentsByDoctorId( string doctorId );
    AppointmentsWithPatientNameDto[] GetAppointmentsByDoctorIdAndData(string doctorId, string date);
    PatientsShortDto[] GetPatientsByDoctorId(string doctorId);
    PatientDto GetPatientById(string patientId);
    void DeleteAppointment(string appointmentId);
    void AddAppointment(string doctorId, string patientId, string dateOfAppointment, string description);
    void AddPatient (string pesel, string name, string surname, string sex, string birthdate, string city, string street, string houseNr);
  }
}
