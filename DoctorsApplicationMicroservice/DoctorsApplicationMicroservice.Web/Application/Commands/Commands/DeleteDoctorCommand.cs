namespace DoctorsApplicationMicroservice.Web.Application.Commands.Commands
{
    //wykorzystujemy interfejs wskaźnikowy ICommand do jawnego wskazania, że dana klasa jest komendą
    public class DeleteDoctorCommand : ICommand
    {
        public int DoctorId { get; set; }
    }
}