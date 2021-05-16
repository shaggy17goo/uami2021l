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


  using ZsutPw.Patterns.WindowsApplication.Model;
  using ZsutPw.Patterns.WindowsApplication.Utilities;

  public partial class Controller : PropertyContainerBase, IController
  {
    public IModel Model { get; private set; }

    public Controller( IEventDispatcher dispatcher, IModel model ) : base( dispatcher )
    {
     Model = model;


     GetAppointmentsByDoctorIdCommand = new ControllerCommand(GetAppointmentsByDoctorId);

     GetPatientsByDoctorIdCommand = new ControllerCommand(GetPatientsByDoctorId);

     GetAppointmentsByDoctorIdAndDateCommand = new ControllerCommand(GetAppointmentsByDoctorIdAndDate);

     GetPatientByIdCommand = new ControllerCommand(GetPatientById);

     DeleteAppointmentCommand = new ControllerCommand(DeleteAppointment);

    AddAppointmentCommand = new ControllerCommand(AddAppointment);

    AddPatientCommand = new ControllerCommand(AddPatient);

    ShowListCommand = new ControllerCommand( this.ShowList );

     ShowMapCommand = new ControllerCommand( this.ShowMap );
    }
  }
}
