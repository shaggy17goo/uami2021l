namespace AppointmentsData.Domain.PatientAggregate
{
    using System;


    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public string Description { get; set; }


        public Appointment(int appointmentId, int doctorId, int patientId, DateTime dateOfAppointment,
            string description)
        {
            AppointmentId = appointmentId;
            DoctorId = doctorId;
            PatientId = patientId;
            DateOfAppointment = dateOfAppointment;
            Description = description;
        }
    }
}