namespace DoctorsApplicationMicroservice.Web.Application.Dtos
{
    using System;

    public class PatientsShortDto
    {
        public int PatientId { get;  set; }
        public string Pesel { get;  set; }
        public string Name { get;  set; }
        public string Surname { get;  set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get;  set; }

        public PatientsShortDto(int patientId, string pesel, string name, string surname, string sex, DateTime birthDate)
        {
            PatientId = patientId;
            Pesel = pesel;
            Name = name;
            Surname = surname;
            Sex = sex;
            BirthDate = birthDate;
        }
        
        public PatientsShortDto(PatientDto patientDto)
        {
            PatientId = patientDto.Id;
            Pesel = patientDto.Pesel;
            Name = patientDto.Name;
            Surname = patientDto.Surname;
            Sex = patientDto.Sex;
            BirthDate = patientDto.BirthDate;
        }
        
        
    }
}