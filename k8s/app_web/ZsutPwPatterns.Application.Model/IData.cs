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

namespace ZsutPw.Patterns.Application.Model
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  using System.ComponentModel;
    using ZsutPw.Patterns.Application.Model.Data;

    public interface IData : INotifyPropertyChanged
  {
    string SearchText { get; set; }
    string VisitDate { get; set; }
    string Pesel { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Sex { get; set; }
        string BirthDate { get; set; }
        string City { get; set; }
        string Street { get; set; }
        string HouseNr { get; set; }
        string DoctorId { get; set; }
        string PatientId { get; set; }
        string DateOfAppointment { get; set; }
        string Description { get; set; }
        PatientDto PatientById { get; }
    List<PatientsShortDto> PatientsByDoctorId { get; }
    PatientsShortDto SelectedPatientsByDoctorId { get; set; }
    List<AppointmentsWithPatientNameDto> AppointmentsByDoctorIdAndData { get; }
    AppointmentsWithPatientNameDto SelectedAppointmentByDoctorIdAndData { get; set; }
    List<AppointmentsWithPatientNameDto> AppointmentsByDoctorId { get; }
    AppointmentsWithPatientNameDto SelectedAppointmentByDoctorId{ get; set; }
    }
}
