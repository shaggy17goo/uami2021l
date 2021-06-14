namespace Model.Data
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
        
        public PatientDto(string name, string surname)
        {
            this.PatientId = 0;
            this.Pesel = "9372509327502";
            this.Name = name;
            this.Surname = surname;
            this.Sex = "M";
            this.BirthDate = DateTime.Now;
            this.City = "city";
            this.Street = "street";
            this.HouseNr = "houseNr";
        }
    }
}
