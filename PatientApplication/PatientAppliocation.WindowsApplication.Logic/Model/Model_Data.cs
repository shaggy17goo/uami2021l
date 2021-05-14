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
    public partial class Model : IData
    {
        private string searchText = "";

        public List<PatientDto> patientById;
        public List<DoctorDto> doctorById;
        
        private List<AppointmentWithNamesDto> appointmentsHistoryWithNamesDtoList = new List<AppointmentWithNamesDto>();
        private AppointmentWithNamesDto selectedAppointmentsHistoryWithNamesDtoDto;
        
        private List<AppointmentWithNamesDto> futureAppointmentWithNamesDtoList = new List<AppointmentWithNamesDto>();
        private AppointmentWithNamesDto selectedFutureAppointmentWithNamesDtoDto;
        
        private List<DoctorDto> doctorDtoList = new List<DoctorDto>();
        private DoctorDto selectedDoctorDto;
        
        private List<PatientDto> patientDtoList = new List<PatientDto>();
        private PatientDto selectedPatientDto;
        


        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;

                RaisePropertyChanged("SearchText");
            }
        }
        
        public List<PatientDto> PatientById
        {
            get => patientById;
            set
            {
                patientById = value;

                RaisePropertyChanged("PatientById");
            }
        }
        
        public List<DoctorDto> DoctorById
        {
            get => doctorById;
            set
            {
                doctorById = value;

                RaisePropertyChanged("DoctorById");
            }
        }
        
        
        public List<AppointmentWithNamesDto> AppointmentsHistoryWithNamesDtoList
        {
            get => appointmentsHistoryWithNamesDtoList;
            private set
            {
                appointmentsHistoryWithNamesDtoList = value;

                RaisePropertyChanged("AppointmentsHistoryWithNamesDtoList");
            }
        }

        public AppointmentWithNamesDto SelectedAppointmentsHistoryWithNamesDtoDto
        {
            get => selectedAppointmentsHistoryWithNamesDtoDto ;
            set
            {
                selectedAppointmentsHistoryWithNamesDtoDto = value;

                RaisePropertyChanged("SelectedAppointmentWithNamesDtoDto");
            }
        }
        

        public List<AppointmentWithNamesDto> FutureAppointmentWithNamesDtoList
        {
            get => futureAppointmentWithNamesDtoList;
            private set
            {
                futureAppointmentWithNamesDtoList = value;

                RaisePropertyChanged("FutureAppointmentWithNamesDtoList");
            }
        }
        
        public AppointmentWithNamesDto SelectedFutureAppointmentWithNamesDtoDto
        {
            get => selectedFutureAppointmentWithNamesDtoDto ;
            set
            {
                selectedFutureAppointmentWithNamesDtoDto = value;

                RaisePropertyChanged("SelectedFutureAppointmentWithNamesDtoDto");
            }
        }
        
        public List<DoctorDto> DoctorDtoList
        {
            get => doctorDtoList;
            private set
            {
                doctorDtoList = value;

                RaisePropertyChanged("DoctorDtoList");
            }
        }

        public DoctorDto SelectedDoctorDto
        {
            get => selectedDoctorDto ;
            set
            {
                selectedDoctorDto = value;

                RaisePropertyChanged("SelectedDoctorDto");
            }
        }
        
        public List<PatientDto> PatientDtoList
        {
            get => patientDtoList;
            private set
            {
                patientDtoList = value;

                RaisePropertyChanged("PatientDtoList");
            }
        }

        public PatientDto SelectedPatientDto
        {
            get => selectedPatientDto ;
            set
            {
                selectedPatientDto = value;

                RaisePropertyChanged("SelectedPatientDto");
            }
        }
        
    }
}