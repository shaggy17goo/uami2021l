namespace AppointmentsData.Web.Application.Commands
{
    //wykorzystujemy interfejs wskaźnikowy ICommand do jawnego wskazania, że dana klasa jest komendą
    public class DeleteAppointmentCommand : ICommand
    {
        public int AppointmentId { get; set; }
    }
}