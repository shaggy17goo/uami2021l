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

using System.Windows.Input;

namespace ZsutPw.Patterns.WindowsApplication.Controller
{
    public partial class Controller : IController
    {
        private ApplicationState currentState = ApplicationState.List;

        public ApplicationState CurrentState
        {
            get => currentState;
            set
            {
                currentState = value;

                RaisePropertyChanged("CurrentState");
            }
        }

        public ICommand GetDoctorsCommand { get; }

        public ICommand GetDoctorByIdCommand { get; }

        public ICommand GetPatientByIdCommand { get; }

        public ICommand GetAppointmentsHistoryCommand { get; }

        public ICommand GetFutureAppointmentsCommand { get; }
        

        private void GetDoctors()
        {
            Model.LoadDoctors();
        }
        
        private void GetDoctorById()
        {
            Model.LoadDoctorById();
        }
        
        private void GetPatientById()
        {
            Model.LoadPatientById();
        }
        
        private void GetAppointmentsHistory()
        {
            Model.LoadAppointmentsHistory();
        }
        
        private void GetFutureAppointments()
        {
            Model.LoadFutureAppointments();
        }
        

        private void ShowList()
        {
            switch (CurrentState)
            {
                case ApplicationState.List:
                    break;

                default:
                    CurrentState = ApplicationState.List;
                    break;
            }
        }

        private void ShowMap()
        {
            switch (CurrentState)
            {
                case ApplicationState.Map:
                    break;

                default:
                    CurrentState = ApplicationState.Map;
                    break;
            }
        }
    }
}