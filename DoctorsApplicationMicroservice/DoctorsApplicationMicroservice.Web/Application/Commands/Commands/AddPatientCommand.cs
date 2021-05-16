namespace DoctorsApplicationMicroservice.Web.Application.Commands.Commands
{
    using System;

    //wykorzystujemy interfejs wskaźnikowy ICommand do jawnego wskazania, że dana klasa jest komendą
    public class AddPatientCommand : ICommand
    {
        public string Pesel { get;  set; }
        public string Name { get;  set; }
        public string Surname { get;  set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get;  set; }
        public string City { get;  set; }
        public string Street { get;  set; }
        public string HouseNr { get;  set; }
    }
}
