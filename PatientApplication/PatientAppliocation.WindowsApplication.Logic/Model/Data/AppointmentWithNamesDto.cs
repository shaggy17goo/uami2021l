using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZsutPw.Patterns.WindowsApplication.Dto
{
    public class AppointmentWithNamesDto
    {
        public int appointmentId { get; set; }
        public string doctorName { get; set; }
        public string doctorSurname { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }

        public DateTime dateOfAppointment { get; set; }
        public string description { get; set; }

        public AppointmentWithNamesDto()
        {
        }

        public AppointmentWithNamesDto(int appointmentId, string doctorName, string doctorSurname, string patientName, string patientSurname, DateTime dateOfAppointment, string description)
        {
            this.appointmentId = appointmentId;
            this.doctorName = doctorName;
            this.doctorSurname = doctorSurname;
            this.patientName = patientName;
            this.patientSurname = patientSurname;
            this.dateOfAppointment = dateOfAppointment;
            this.description = description;
        }
    }
}
