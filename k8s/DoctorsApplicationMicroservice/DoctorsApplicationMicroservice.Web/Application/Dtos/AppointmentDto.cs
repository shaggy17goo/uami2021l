namespace DoctorsApplicationMicroservice.Web.Application.Dtos
{
    using System;

    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public string Description { get; set; }

        public AppointmentDto(int appointmentId, int doctorId, int patientId, DateTime dateOfAppointment,
            string description)
        {
            AppointmentId = appointmentId;
            DoctorId = doctorId;
            PatientId = patientId;
            DateOfAppointment = dateOfAppointment;
            Description = description;
        }

        public AppointmentDto(int appointmentId, int doctorId, int patientId, string description)
        {
            AppointmentId = appointmentId;
            DoctorId = doctorId;
            PatientId = patientId;
            DateOfAppointment = DateTime.Now;
            Description = description;
        }

    }
}