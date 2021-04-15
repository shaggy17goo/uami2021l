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

    }
}