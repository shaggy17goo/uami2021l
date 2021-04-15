﻿namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DoctorDto
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

        public IList<int> Certifications { get; private set; } = new List<int>();

    }
}
    