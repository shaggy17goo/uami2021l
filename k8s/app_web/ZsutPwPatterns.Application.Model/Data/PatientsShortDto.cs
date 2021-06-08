namespace ZsutPw.Patterns.Application.Model.Data
{
    using System;

    public class PatientsShortDto
    {
        public int PatientId { get; set; }
        public string Pesel { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }

        public PatientsShortDto(int patientId, string pesel, string name, string surname, string sex, DateTime birthDate)
        {
            PatientId = patientId;
            Pesel = pesel;
            Name = name;
            Surname = surname;
            Sex = sex;
            BirthDate = birthDate;
        }

 


    }
}