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

namespace ZsutPw.Patterns.Application.Controller
{
    using System.Threading.Tasks;
    using ZsutPw.Patterns.Application.Model;
  using ZsutPw.Patterns.Application.Utilities;

  public partial class Controller : PropertyContainerBase, IController
  {
    public IModel Model { get; private set; }

        public Controller(IEventDispatcher dispatcher, IModel model) : base(dispatcher)
        {
            Model = model;
        }
        public async Task GetAppointmentsByDoctorIdAsync()
        {
            await Task.Run(GetAppointmentsByDoctorId);
        }

        public async Task GetAppointmentsByDoctorIdAndDateAsync()
        {
            await Task.Run(GetAppointmentsByDoctorIdAndDate);
        }

        public async Task GetPatientsByDoctorIdAsync()
        {
            await Task.Run(GetPatientsByDoctorId);
        }

        public async Task GetPatientByIdAsync()
        {
            await Task.Run(GetPatientById);
        }

        public async Task DeleteAppointmentAsync()
        {
            await Task.Run(DeleteAppointment);
        }

        public async Task AddAppointmentAsync()
        {
            await Task.Run(AddAppointment);
        }

        public async Task AddPatientAsync()
        {
            await Task.Run(AddPatient);
        }
        private void GetAppointmentsByDoctorId()
        {
            Model.LoadAppointmentsByDoctorId();
        }

        private void GetAppointmentsByDoctorIdAndDate()
        {
            Model.LoadAppointmentsByDoctorIdAndDate();
        }

        private void GetPatientsByDoctorId()
        {
            Model.LoadPatientsByDoctorId();
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

    }
}

