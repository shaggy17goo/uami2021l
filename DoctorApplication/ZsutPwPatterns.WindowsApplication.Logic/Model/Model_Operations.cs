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
  public partial class Model : IOperations
  {
    public void LoadAppointmentsByDoctorId()
        {
            Task.Run(() => LoadAppointmentsByDoctorIdTask());
        }
    public void LoadAppointmentsByDoctorIdAndDate()
        {
            Task.Run(() => LoadAppointmentsByDoctorIdAndDataTask());
        }
    public void LoadPatientsByDoctorId()
        {
            Task.Run(() => LoadPatientsByDoctorIdTask());
        }
    public void LoadPatientById()
        {
            Task.Run(() => LoadPatientByIdTask());
        }
    public void DeleteAppointment()
        {
            Task.Run(() => DeleteAppointmentTask());
        }
    public void AddAppointment()
        {
            Task.Run(() => AddAppointmentTask());
        }
    public void AddPatient()
        {
            Task.Run(() => AddPatientTask());
        }

        private void AddPatientTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                networkClient.AddPatient(Pesel, Name, Surname, Sex, BirthDate, City, Street, HouseNr);

            }
            catch (Exception e)
            {
                string mess = e.Message;
            }
        }
        private void AddAppointmentTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                networkClient.AddAppointment(DoctorId, PatientId, DateOfAppointment, Description);

            }
            catch (Exception e)
            {
                string mess = e.Message;
            }
        }

        private void DeleteAppointmentTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                networkClient.DeleteAppointment(SearchText);

            }
            catch (Exception e)
            {
                string mess = e.Message;
            }
        }

        private void LoadAppointmentsByDoctorIdTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var appointments = networkClient.GetAppointmentsByDoctorId(SearchText);

                AppointmentsByDoctorId = appointments.ToList();
            }
            catch (Exception)
            {
            }
        }
    private void LoadAppointmentsByDoctorIdAndDataTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var appointments = networkClient.GetAppointmentsByDoctorIdAndData(SearchText, VisitDate);

                AppointmentsByDoctorIdAndData = appointments.ToList();
            }
            catch (Exception)
            {
            }
        }
    private void LoadPatientsByDoctorIdTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var patients = networkClient.GetPatientsByDoctorId(SearchText);

                PatientsByDoctorId = patients.ToList();
            }
            catch (Exception e)
            {
                string ExceptionMess = e.Message;

            }
        }
    private void LoadPatientByIdTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var patient = networkClient.GetPatientById(SearchText);

                PatientById = patient;
            }
            catch (Exception)
            {
            }
        }
    }
}
