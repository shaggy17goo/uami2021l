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
    using ZsutPw.Patterns.WindowsApplication.Model.Data;

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
        public string VisitDate
        {
            get { return this.visitDate; }
            set
            {
                this.visitDate = value;

                this.RaisePropertyChanged("visitDate");
            }
        }

        private string searchText ="";
        private string visitDate;
        private List<AppointmentsWithPatientNameDto> appointmentsByDoctorId = new List<AppointmentsWithPatientNameDto>();
        private AppointmentsWithPatientNameDto selectedAppoitment;
        private List<AppointmentsWithPatientNameDto> appointmentsByDoctorIdAndData = new List<AppointmentsWithPatientNameDto>();
        private List<PatientsShortDto> patientsByDoctorId = new List<PatientsShortDto>();
        private PatientDto patientById;
        private PatientsShortDto selectedPatientsByDoctorId;
        public List<AppointmentsWithPatientNameDto> AppointmentsByDoctorId
        {
            get { return appointmentsByDoctorId; }
           private set
            {
                appointmentsByDoctorId = value;

                RaisePropertyChanged("AppointmentsByDoctorId");
            }
        }
        public AppointmentsWithPatientNameDto SelectedAppointment
        {
            get { return selectedAppoitment; }
            set
            {
                selectedAppoitment = value;

                RaisePropertyChanged("SelectedAppointment");
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
        public PatientsShortDto SelectedPatientsByDoctorId
        {
            get { return selectedPatientsByDoctorId; }
            set
            {
                 selectedPatientsByDoctorId = value;

                RaisePropertyChanged("SelectedPatientsByDoctorId");
}
        }

    }
}
