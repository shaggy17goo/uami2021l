using System;

namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    public class PatientsShortDto
    {
        public int patientId { get;  set; }
        public string PESEL { get;  set; }
        public string name { get;  set; }
        public string surname { get;  set; }
        public string sex { get; set; }
        public DateTime birthDate { get;  set; }

        public PatientsShortDto(int patientId, string pesel, string name, string surname, string sex, DateTime birthDate)
        {
            this.patientId = patientId;
            PESEL = pesel;
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.birthDate = birthDate;
        }
        
        public PatientsShortDto(PatientDto patientDto)
        {
            this.patientId = patientDto.patientId;
            PESEL = patientDto.PESEL;
            this.name = patientDto.name;
            this.surname = patientDto.surname;
            this.sex = patientDto.sex;
            this.birthDate = patientDto.birthDate;
        }
        
        
    }
}