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

using ZsutPw.Patterns.WindowsApplication.Model;
using ZsutPw.Patterns.WindowsApplication.Utilities;

namespace ZsutPw.Patterns.WindowsApplication.Controller
{
    public partial class Controller : PropertyContainerBase, IController
    {
        public Controller(IEventDispatcher dispatcher, IModel model) : base(dispatcher)
        {
            Model = model;

            GetDoctorsCommand = new ControllerCommand(GetDoctors);

            GetDoctorByIdCommand = new ControllerCommand(GetDoctorById);
            
            GetPatientByIdCommand = new ControllerCommand(GetPatientById);
            
            GetAppointmentsHistoryCommand = new ControllerCommand(GetAppointmentsHistory);
            
            GetFutureAppointmentsCommand = new ControllerCommand(GetFutureAppointments);
        }

        public IModel Model { get; }

    }
}