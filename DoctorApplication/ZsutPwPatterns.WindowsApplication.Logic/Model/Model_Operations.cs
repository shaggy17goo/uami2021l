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

  public partial class Model : IOperations
  {
    public void LoadAppointmentsByDoctorId()
        {
            Task.Run(() => LoadAppointmentsByDoctorIdTask());
        }
    public void LoadAppointmentsByDoctorIdAndData()
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
    private void LoadAppointmentsByDoctorIdTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var appointments = networkClient.GetAppointmentsByDoctorId(searchText);

                appointmentsByDoctorId = appointments.ToList();
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
                var appointments = networkClient.GetAppointmentsByDoctorIdAndData(searchText, searchText);

                appointmentsByDoctorIdAndData = appointments.ToList();
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
                var patients = networkClient.GetPatientsByDoctorId(searchText);

                patientsByDoctorId = patients.ToList();
            }
            catch (Exception)
            {
            }
        }
    private void LoadPatientByIdTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var patient = networkClient.GetPatientById(searchText);

                patientById = patient;
            }
            catch (Exception)
            {
            }
        }
    }
}
