using System;

namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    public class PatientDto
    {
        public int patientId { get;  set; }
        public string PESEL { get;  set; }
        public string name { get;  set; }
        public string surname { get;  set; }
        public string sex { get; set; }
        public DateTime birthDate { get;  set; }
        public string city { get;  set; }
        public string street { get;  set; }
        public string houseNr { get;  set; }

        public PatientDto(int patientId, string pesel, string name, string surname, string sex, DateTime birthDate, string city, string street, string houseNr)
        {
            this.patientId = patientId;
            PESEL = pesel;
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.birthDate = birthDate;
            this.city = city;
            this.street = street;
            this.houseNr = houseNr;
        }
    }
}