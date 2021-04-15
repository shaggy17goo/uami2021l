namespace DoctorsApplicationMicroservice.Web.Application.Dtos
{
    using System;

    public class AppointmentDto
    {
        public int appointmentId { get; set; }
        public int doctorId { get; set; }
        public int patientId { get; set; }
        public DateTime dateOfAppointment { get; set; }
        public string description { get; set; }
        public AppointmentDto(int appointmentId, int doctorId, int patientId, DateTime dateOfAppointment, string description)
        {
            this.appointmentId = appointmentId;
            this.doctorId = doctorId;
            this.patientId = patientId;
            this.dateOfAppointment = dateOfAppointment;
            this.description = description;
        }

    }
}