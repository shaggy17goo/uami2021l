namespace Model.Data
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

        public DoctorDto(string name, string surname)
        {
            this.id = 0;
            this.pesel = "9372509327502";
            this.name = name;
            this.surname = surname;
            this.sex = "M";
            this.birthDate = DateTime.Now;
            this.city = "city";
            this.street = "street";
            this.houseNr = "houseNr";
            this.certifications = new List<int> {1, 2, 3, 4};
        }
    }
}
