namespace DoctorsApplicationMicroservice.Web.Application.Dtos
{
    using System;

    public class PatientDto
    {
        public int Id { get;  set; }
        public string Pesel { get;  set; }
        public string Name { get;  set; }
        public string Surname { get;  set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get;  set; }
        public string City { get;  set; }
        public string Street { get;  set; }
        public string HouseNr { get;  set; }

        public PatientDto(int id, string pesel, string name, string surname, string sex, DateTime birthDate, string city, string street, string houseNr)
        {
            Id = id;
            Pesel = pesel;
            Name = name;
            Surname = surname;
            Sex = sex;
            BirthDate = birthDate;
            City = city;
            Street = street;
            HouseNr = houseNr;
        }
        
        public PatientDto(int id, string name, string surname, string pesel)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Pesel = pesel;
            Sex = "M";
            BirthDate = DateTime.Now;
            City = "City";
            Street = "Street";
            HouseNr = "1";
        }
    }
}