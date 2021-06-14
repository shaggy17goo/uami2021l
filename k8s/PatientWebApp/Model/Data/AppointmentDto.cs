using System;


namespace Model.Data
{
    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }  
        public DateTime DateOfAppointment { get; set; }
        public string Description { get; set; }
    }
}
