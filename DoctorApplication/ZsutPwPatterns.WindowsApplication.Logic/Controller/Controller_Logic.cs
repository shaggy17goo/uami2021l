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

namespace ZsutPw.Patterns.WindowsApplication.Controller
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;
  using System.Threading.Tasks;

  using System.Windows.Input;

  public partial class Controller : IController
  {
    public ApplicationState CurrentState
    {
      get { return this.currentState; }
      set
      {
        this.currentState = value;

        this.RaisePropertyChanged( "CurrentState" );
      }
    }
    private ApplicationState currentState = ApplicationState.List;

    public ICommand GetAppointmentsByDoctorIdCommand { get; private set; }

    public ICommand GetAppointmentsByDoctorIdAndDateCommand { get; private set; }

    public ICommand GetPatientsByDoctorIdCommand { get; private set; }

    public ICommand GetPatientByIdCommand { get; private set; }

    public ICommand DeleteAppointmentCommand { get; private set; }

    public ICommand AddAppointmentCommand { get; private set; }

        public ICommand AddPatientCommand { get; private set; }

        public ICommand ShowListCommand { get; private set; }

    public ICommand ShowMapCommand { get; private set; }

    


    private void GetAppointmentsByDoctorId()
    {
        this.Model.LoadAppointmentsByDoctorId();
    }

    private void GetPatientsByDoctorId()
    {
            this.Model.LoadPatientsByDoctorId();
    }

    private void GetAppointmentsByDoctorIdAndDate()
        {
            Model.LoadAppointmentsByDoctorIdAndDate();
        }

    private void GetPatientById()
        {
            Model.LoadPatientById();
        }
       

    private void DeleteAppointment()
        {
            Model.DeleteAppointment();
        }
    private void AddAppointment()
        {
            Model.AddAppointment();
        }
    private void AddPatient()
        {
            Model.AddPatient();
        }

        private void ShowList( )
    {
      switch( this.CurrentState )
      {
        case ApplicationState.List:
          break;

        default:
          this.CurrentState = ApplicationState.List;
          break;
      }
    }

    private void ShowMap( )
    {
      switch( this.CurrentState )
      {
        case ApplicationState.Map:
          break;

        default:
          this.CurrentState = ApplicationState.Map;
          break;
      }
    }
  }
}
