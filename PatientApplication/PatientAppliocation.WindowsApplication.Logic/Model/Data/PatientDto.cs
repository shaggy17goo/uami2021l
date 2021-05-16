namespace ZsutPw.Patterns.WindowsApplication.Dto
{
    using System;

    public class PatientDto
    {
        public int patientId { get; set; }
        public string PESEL { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string sex { get; set; }
        public DateTime birthDate { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string houseNr { get; set; }
        
        public PatientDto(string name, string surname)
        {
            this.patientId = 0;
            this.PESEL = "9372509327502";
            this.name = name;
            this.surname = surname;
            this.sex = "M";
            this.birthDate = DateTime.Now;
            this.city = "city";
            this.street = "street";
            this.houseNr = "houseNr";
        }
    }
}
