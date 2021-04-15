namespace DoctorsApplicationMicroservice.Web.Application.Commands.Commands
{
    using System;

    //wykorzystujemy interfejs wskaźnikowy ICommand do jawnego wskazania, że dana klasa jest komendą
    public class AddAppointmentCommand : ICommand
    {
        public int appointmentId { get; set; }
        public int doctorId { get; set; }
        public int patientId { get; set; }
        public DateTime dateOfAppointment { get; set; }
        public string description { get; set; }
    }
}