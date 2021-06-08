namespace ZsutPw.Patterns.Application.Model.Data
{
    using System;

    public class PatientDto
    {
        public int PatientId { get; set; }
        public string Pesel { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }

        public PatientDto(int patientId, string pesel, string name, string surname, string sex, DateTime birthDate, string city, string street, string houseNr)
        {
            PatientId = patientId;
            Pesel = pesel;
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