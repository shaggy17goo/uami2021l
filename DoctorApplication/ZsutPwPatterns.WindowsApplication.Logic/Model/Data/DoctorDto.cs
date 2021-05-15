namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;

    public class DoctorDto
    {
        public int Id { get; private set; }
        public string PESEL { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string HouseNr { get; private set; }

        public IList<int> Certifications { get; private set; } = new List<int>();

        public DoctorDto(int id, string pesel, string name, string surname, string sex, DateTime birthDate, string city, string street, string houseNr)
        {
            Id = id;
            PESEL = pesel;
            Name = name;
            Surname = surname;
            Sex = sex;
            BirthDate = birthDate;
            City = city;
            Street = street;
            HouseNr = houseNr;
        }
    }
}
    