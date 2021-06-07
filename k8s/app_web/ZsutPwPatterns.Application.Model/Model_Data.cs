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
    using ZsutPw.Patterns.Application.Model.Data;

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

                this.RaisePropertyChanged("VisitDate");
            }
        }
        public string Pesel
        {
            get { return this.pesel; }
            set
            {
                this.pesel = value;

                this.RaisePropertyChanged("Pesel");
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;

                this.RaisePropertyChanged("Name");
            }
        }
        public string Surname
        {
            get { return this.surname; }
            set
            {
                this.surname = value;

                this.RaisePropertyChanged("Surname");
            }
        }
        public string Sex
        {
            get { return this.sex; }
            set
            {
                this.sex = value;

                this.RaisePropertyChanged("Sex");
            }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set
            {
                this.birthDate = value;

                this.RaisePropertyChanged("BirthDate");
            }
        }
        public string City
        {
            get { return this.city; }
            set
            {
                this.city = value;

                this.RaisePropertyChanged("City");
            }
        }
        public string Street
        {
            get { return this.street; }
            set
            {
                this.street = value;

                this.RaisePropertyChanged("Street");
            }
        }
        public string HouseNr
        {
            get { return this.houseNr; }
            set
            {
                this.houseNr = value;

                this.RaisePropertyChanged("HouseNr");
            }
        }
        public string DoctorId
        {
            get { return this.doctorId; }
            set
            {
                this.doctorId = value;

                this.RaisePropertyChanged("DoctorId");
            }
        }
        public string PatientId
        {
            get { return this.patientId; }
            set
            {
                this.patientId = value;

                this.RaisePropertyChanged("PatientId");
            }
        }
        public string DateOfAppointment
        {
            get { return this.dateOfAppointment; }
            set
            {
                this.dateOfAppointment = value;

                this.RaisePropertyChanged("DateOfAppointment");
            }
        }
        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;

                this.RaisePropertyChanged("Description");
            }
        }
        private string pesel;
        private string name;
        private string surname;
        private string sex;
        private string birthDate;
        private string city;
        private string street;
        private string houseNr;
        private string doctorId;
        private string patientId;
        private string dateOfAppointment;
        private string description;
        private string searchText ="";
        private string visitDate;
        private List<AppointmentsWithPatientNameDto> appointmentsByDoctorId = new List<AppointmentsWithPatientNameDto>();
        private AppointmentsWithPatientNameDto selectedAppoitmentByDoctorId;
        private List<AppointmentsWithPatientNameDto> appointmentsByDoctorIdAndData = new List<AppointmentsWithPatientNameDto>();
        private AppointmentsWithPatientNameDto selectedAppointmentByDoctorIdAndData;
        private List<PatientsShortDto> patientsByDoctorId = new List<PatientsShortDto>();
        private PatientsShortDto selectedPatientsByDoctorId;
        private List<PatientDto> patientById;
        public List<AppointmentsWithPatientNameDto> AppointmentsByDoctorId
        {
            get { return appointmentsByDoctorId; }
           private set
            {
                appointmentsByDoctorId = value;

                RaisePropertyChanged("AppointmentsByDoctorId");
            }
        }
        public AppointmentsWithPatientNameDto SelectedAppointmentByDoctorId
        {
            get { return selectedAppoitmentByDoctorId; }
            set
            {
                selectedAppoitmentByDoctorId = value;

                RaisePropertyChanged("SelectedAppointmentByDoctorId");
            }
        }
        public AppointmentsWithPatientNameDto SelectedAppointmentByDoctorIdAndData
        {
            get { return selectedAppointmentByDoctorIdAndData; }
            set
            {
                selectedAppointmentByDoctorIdAndData = value;

                RaisePropertyChanged("SelectedAppointmentByDoctorIdAndData");
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
        public List<PatientDto> PatientById
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
