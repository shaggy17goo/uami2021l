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
namespace Model
{
    
    using System.Collections.Generic;
    using Data;
    public partial class Model : IData
    {
        private string _searchText = "";

        private List<PatientDto> _patientById = new List<PatientDto>();
        private List<DoctorDto> _doctorById = new List<DoctorDto>();
        
        private List<AppointmentWithNamesDto> _appointmentsHistoryWithNamesDtoList = new List<AppointmentWithNamesDto>();
        private AppointmentWithNamesDto _selectedAppointmentsHistoryWithNamesDtoDto;
        
        private List<AppointmentWithNamesDto> _futureAppointmentWithNamesDtoList = new List<AppointmentWithNamesDto>();
        private AppointmentWithNamesDto _selectedFutureAppointmentWithNamesDtoDto;
        
        private List<DoctorDto> _doctorDtoList = new List<DoctorDto>();
        private DoctorDto _selectedDoctorDto;
        
        private List<PatientDto> _patientDtoList = new List<PatientDto>();
        private PatientDto _selectedPatientDto;
        


        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;

                RaisePropertyChanged(nameof(SearchText));
            }
        }
        
        public List<PatientDto> PatientById
        {
            get => _patientById;
            set
            {
                _patientById = value;

                RaisePropertyChanged(nameof(PatientById));
            }
        }
        
        public List<DoctorDto> DoctorById
        {
            get => _doctorById;
            set
            {
                _doctorById = value;

                RaisePropertyChanged(nameof(DoctorById));
            }
        }
        
        
        public List<AppointmentWithNamesDto> AppointmentsHistoryWithNamesDtoList
        {
            get => _appointmentsHistoryWithNamesDtoList;
            private set
            {
                _appointmentsHistoryWithNamesDtoList = value;

                RaisePropertyChanged(nameof(AppointmentsHistoryWithNamesDtoList));
            }
        }

        public AppointmentWithNamesDto SelectedAppointmentsHistoryWithNamesDtoDto
        {
            get => _selectedAppointmentsHistoryWithNamesDtoDto ;
            set
            {
                _selectedAppointmentsHistoryWithNamesDtoDto = value;

                RaisePropertyChanged("SelectedAppointmentWithNamesDtoDto");
            }
        }
        

        public List<AppointmentWithNamesDto> FutureAppointmentWithNamesDtoList
        {
            get => _futureAppointmentWithNamesDtoList;
            private set
            {
                _futureAppointmentWithNamesDtoList = value;

                RaisePropertyChanged(nameof(FutureAppointmentWithNamesDtoList));
            }
        }
        
        public AppointmentWithNamesDto SelectedFutureAppointmentWithNamesDtoDto
        {
            get => _selectedFutureAppointmentWithNamesDtoDto ;
            set
            {
                _selectedFutureAppointmentWithNamesDtoDto = value;

                RaisePropertyChanged(nameof(SelectedFutureAppointmentWithNamesDtoDto));
            }
        }
        
        public List<DoctorDto> DoctorDtoList
        {
            get => _doctorDtoList;
            private set
            {
                _doctorDtoList = value;

                RaisePropertyChanged(nameof(DoctorDtoList));
            }
        }

        public DoctorDto SelectedDoctorDto
        {
            get => _selectedDoctorDto ;
            set
            {
                _selectedDoctorDto = value;

                RaisePropertyChanged(nameof(SelectedDoctorDto));
            }
        }
        
        public List<PatientDto> PatientDtoList
        {
            get => _patientDtoList;
            private set
            {
                _patientDtoList = value;

                RaisePropertyChanged(nameof(PatientDtoList));
            }
        }

        public PatientDto SelectedPatientDto
        {
            get => _selectedPatientDto ;
            set
            {
                _selectedPatientDto = value;

                RaisePropertyChanged(nameof(SelectedPatientDto));
            }
        }
        
    }
}