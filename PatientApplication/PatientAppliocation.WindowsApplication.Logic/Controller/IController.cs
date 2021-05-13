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

using System.ComponentModel;
using System.Windows.Input;
using ZsutPw.Patterns.WindowsApplication.Model;

namespace ZsutPw.Patterns.WindowsApplication.Controller
{
    public interface IController : INotifyPropertyChanged
    {
        IModel Model { get; }

        ApplicationState CurrentState { get; }

        ICommand GetDoctorsCommand { get; }

        ICommand GetDoctorByIdCommand { get; }

        ICommand GetPatientByIdCommand { get; }

        ICommand GetAppointmentsHistoryCommand { get; }

        ICommand GetFutureAppointmentsCommand { get; }

    }
}