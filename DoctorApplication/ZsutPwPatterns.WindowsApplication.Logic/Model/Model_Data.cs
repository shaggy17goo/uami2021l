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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public partial class Model : IData
    {
        public string SearchText
        {
            get { return this.searchText; }
            set
            {
                this.searchText = value;

                this.RaisePropertyChanged("SearchText");
            }
        }
        private string searchText;
        private List<AppointmentsWithPatientNameDto> appointmentsByDoctorId = new List<AppointmentsWithPatientNameDto>();
        private List<AppointmentsWithPatientNameDto> appointmentsByDoctorIdAndData = new List<AppointmentsWithPatientNameDto>();
        private List<PatientsShortDto> patientsByDoctorId = new List<PatientsShortDto>();
        private PatientDto patientById;
        public List<AppointmentsWithPatientNameDto> AppointmentsByDoctorId
        {
            get { return appointmentsByDoctorId; }
            set
            {
                appointmentsByDoctorId = value;

                RaisePropertyChanged("AppointmentsByDoctorId");
            }
        }
        public List<AppointmentsWithPatientNameDto> AppointmentsByDoctorIdAndData 
        {
            get { return appointmentsByDoctorIdAndData; }
            set
            {
                appointmentsByDoctorIdAndData = value;

                RaisePropertyChanged("AppointmentsByDoctorIdAndData");
            }
        }
        public List<PatientsShortDto> PatientsByDoctorId
        {
            get { return patientsByDoctorId; }
            set
            {
                patientsByDoctorId = value;

                RaisePropertyChanged("PatientsByDoctorId");
            }
        }
        public PatientDto PatientById
        {
            get { return patientById; }
            set
            {
                patientById = value;

                RaisePropertyChanged("PatientById");
            }
        }

    }
}
