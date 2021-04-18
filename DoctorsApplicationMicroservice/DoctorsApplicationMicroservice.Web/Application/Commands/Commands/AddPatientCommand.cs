﻿namespace DoctorsApplicationMicroservice.Web.Application.Commands.Commands
{
    using System;

    //wykorzystujemy interfejs wskaźnikowy ICommand do jawnego wskazania, że dana klasa jest komendą
    public class AddPatientCommand : ICommand
    {
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