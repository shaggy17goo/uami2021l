using System;


namespace PatientsApplicationMicroservice.Application.Dtos
{
    public class AppointmentDto
    {
        public int appointmentId { get; set; }
        public int doctorId { get; set; }
        public int patientId { get; set; }  
        public DateTime dateOfAppointment { get; set; }
        public string description { get; set; }
    }
}
