namespace DoctorsApplicationMicroservice.Web.Application.Commands.Commands
{
    using System;

    //wykorzystujemy interfejs wskaźnikowy ICommand do jawnego wskazania, że dana klasa jest komendą
    public class AddAppointmentCommand : ICommand
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public string Description { get; set; }
    }
}