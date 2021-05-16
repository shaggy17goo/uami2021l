namespace Doctors.Web.Application.Commands
{
    using System;
    using System.Collections.Generic;

    //used pointer interface ICommand for explict indication that the class is a command
    public class AddDoctorCommand : ICommand
    {
        public int Id { get; set; }
        public string PESEL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public IEnumerable<int> Certifications { get; set; }
    }
}
