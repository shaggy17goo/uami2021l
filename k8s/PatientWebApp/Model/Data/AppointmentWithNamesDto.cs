using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Data
{
    public class AppointmentWithNamesDto
    {
        public int AppointmentId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }

        public DateTime DateOfAppointment { get; set; }
        public string Description { get; set; }

        public AppointmentWithNamesDto()
        {
        }

        public AppointmentWithNamesDto(int appointmentId, string doctorName, string doctorSurname, string patientName, string patientSurname, DateTime dateOfAppointment, string description)
        {
            this.AppointmentId = appointmentId;
            this.DoctorName = doctorName;
            this.DoctorSurname = doctorSurname;
            this.PatientName = patientName;
            this.PatientSurname = patientSurname;
            this.DateOfAppointment = dateOfAppointment;
            this.Description = description;
        }
    }
}
