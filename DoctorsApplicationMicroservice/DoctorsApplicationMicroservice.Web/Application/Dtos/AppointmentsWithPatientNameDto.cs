using System;

namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    public class AppointmentsWithPatientNameDto
    {
        public int appointmentId { get; set; }
        public int doctorId { get; set; }
        public int patientId { get; set; }
        public DateTime dateOfAppointment { get; set; }
        public string description { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }
    }
}