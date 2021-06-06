﻿//===============================================================================
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
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public interface IOperations
  {
    
    void LoadDoctors();
    
    void LoadDoctorById();
    
    void LoadPatientById();
    
    void LoadAppointmentsHistory();

    void LoadFutureAppointments();
    
  }
}