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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Data;
using Model.Service;

namespace Model
{
    public partial class Model : IOperations
    {
        
        public void LoadDoctors()
        {
            Task.Run(LoadDoctorsTask);
        }

        public void LoadDoctorById()
        {
            Task.Run(LoadDoctorByIdTask);
        }

        public void LoadPatientById()
        {
            Task.Run(LoadPatientByIdTask);
        }

        public void LoadAppointmentsHistory()
        {
            Task.Run(LoadAppointmentsHistoryTask);
        }

        public void LoadFutureAppointments()
        {
            Task.Run(LoadFutureAppointmentsTask);
        }
        
        
        private void LoadDoctorsTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var doctors = networkClient.GetDoctorDtoList();

                DoctorDtoList = doctors.ToList();
            }
            catch (Exception)
            {
                throw new NotConnectedException();
            }
        }
        
        private void LoadDoctorByIdTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var doctor = networkClient.GetDoctorById(SearchText);
                var temp = new List<DoctorDto>{doctor};
                DoctorById = temp;
            }
            catch (Exception)
            {
                throw new NotConnectedException();
            }
        }
        
        private void LoadPatientByIdTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var patient = networkClient.GetPatientById(SearchText);
                var temp = new List<PatientDto>{patient};
                PatientById = temp;
            }
            catch (Exception)
            {
                throw new NotConnectedException();
            }
        }
        
        private void LoadAppointmentsHistoryTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var appointments = networkClient.GetAppointmentsHistoryWithNamesDtoList(SearchText);

                AppointmentsHistoryWithNamesDtoList = appointments.ToList();
            }
            catch (Exception)
            {
                throw new NotConnectedException();
            }
        }
        
        private void LoadFutureAppointmentsTask()
        {
            var networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                var appointments = networkClient.GetFutureAppointmentWithNamesDtoList(SearchText);

                FutureAppointmentWithNamesDtoList = appointments.ToList();
            }
            catch (Exception)
            {
                throw new NotConnectedException();
            }
        }

    }
}
