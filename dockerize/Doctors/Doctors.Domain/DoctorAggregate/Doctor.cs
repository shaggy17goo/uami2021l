namespace Doctors.Domain.DoctorAggregate
{
    using System;
    using System.Collections.Generic;

    public class Doctor
    {
        public int Id { get; private set; }
        public string PESEL { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set;  }
        public string HouseNr { get; private set; }

        public IList<Certification> Certifications { get; private set; } = new List<Certification>();

        public Doctor(int id, string pESEL, string name, string surname, string sex, DateTime birthDate, string city, string street, string houseNr)
        {
            Id = id;
            PESEL = pESEL;
            Name = name;
            Surname = surname;
            Sex = sex;
            BirthDate = birthDate;
            City = city;
            Street = street;
            HouseNr = houseNr;
        }

        public Doctor(int dId, string pESEL, string name, string surname, string sex, DateTime birthDate, string city, string street, string houseNr, IList<Certification> certifications)
        {
            Id = dId;
            PESEL = pESEL;
            Name = name;
            Surname = surname;
            Sex = sex;
            BirthDate = birthDate;
            City = city;
            Street = street;
            HouseNr = houseNr;
            Certifications = certifications;
        }

        public void AddCertification(Certification certification)
        {
            Certifications.Add(certification);
        }
        public void AddCertifications(IEnumerable<Certification> certifications)
        {
            foreach(var certification in certifications)
                Certifications.Add(certification);
        }
    }
}
