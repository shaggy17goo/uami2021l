namespace DoctorsApplicationMicroservice.Web.Application.Commands.Commands
{
    //wykorzystujemy interfejs wskaźnikowy ICommand do jawnego wskazania, że dana klasa jest komendą
    public class DeletePatientCommand : ICommand
    {
        public int patientId { get; set; }
    }
}