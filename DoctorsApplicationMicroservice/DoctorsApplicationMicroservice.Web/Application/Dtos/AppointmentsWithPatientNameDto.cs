namespace DoctorsApplicationMicroservice.Web.Application.Dtos
{
    using System;

    public class AppointmentsWithPatientNameDto
    {
        public int appointmentId { get; set; }
        public int doctorId { get; set; }
        public int patientId { get; set; }
        public DateTime dateOfAppointment { get; set; }
        public string description { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }

        public AppointmentsWithPatientNameDto(int appointmentId, int doctorId, int patientId, DateTime dateOfAppointment, string description, string patientName, string patientSurname)
        {
            this.appointmentId = appointmentId;
            this.doctorId = doctorId;
            this.patientId = patientId;
            this.dateOfAppointment = dateOfAppointment;
            this.description = description;
            this.patientName = patientName;
            this.patientSurname = patientSurname;
        }
    }
}