namespace ZsutPw.Patterns.WindowsApplication.Dto
{
    using System;
    using System.Collections.Generic;

    public class DoctorDto
    {
        public int id { get; set; }
        public string pesel { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string sex { get; set; }
        public DateTime birthDate { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string houseNr { get; set; }
        public List<int> certifications { get; set; }

    }
}
