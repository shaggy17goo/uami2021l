﻿
namespace ZsutPw.Patterns.WindowsApplication.Model.Data
{
    using System;

    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string DateOfAppointment { get; set; }
        public string Description { get; set; }
        public AppointmentDto(int appointmentId, int doctorId, int patientId, string dateOfAppointment, string description)
        {
            AppointmentId = appointmentId;
            DoctorId = doctorId;
            PatientId = patientId;
            DateOfAppointment = dateOfAppointment;
            Description = description;
        }

    }
}