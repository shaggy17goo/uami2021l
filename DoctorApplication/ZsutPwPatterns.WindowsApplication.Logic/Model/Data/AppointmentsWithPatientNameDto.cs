using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZsutPwPatterns.WindowsApplication.Logic.Model.Data
{
        using System;

        public class AppointmentsWithPatientNameDto
        {
            public int AppointmentId { get; set; }
            public int DoctorId { get; set; }
            public int PatientId { get; set; }
            public DateTime DateOfAppointment { get; set; }
            public string Description { get; set; }
            public string PatientName { get; set; }
            public string PatientSurname { get; set; }

            public AppointmentsWithPatientNameDto(int appointmentId, int doctorId, int patientId, DateTime dateOfAppointment, string description, string patientName, string patientSurname)
            {
                AppointmentId = appointmentId;
                DoctorId = doctorId;
                PatientId = patientId;
                DateOfAppointment = dateOfAppointment;
                Description = description;
                PatientName = patientName;
                PatientSurname = patientSurname;
            }
        }
 }


