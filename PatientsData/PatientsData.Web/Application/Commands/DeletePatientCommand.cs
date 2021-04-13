namespace PatientsData.Web.Application.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    //wykorzystujemy interfejs wskaźnikowy ICommand do jawnego wskazania, że dana klasa jest komendą
    public class DeletePatientCommand : ICommand
    {
        public int patientId { get; set; }
        public string PESEL { get; set; }
    }
}