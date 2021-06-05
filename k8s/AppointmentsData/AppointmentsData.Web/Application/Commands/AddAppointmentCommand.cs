using System;

namespace AppointmentsData.Web.Application.Commands
{
    public class AddAppointmentCommand : ICommand
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public string Description { get; set; }
    }
}