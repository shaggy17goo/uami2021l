using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Windows.UI.Xaml.Data;
using ZsutPw.Patterns.WindowsApplication.Dto;
using ZsutPw.Patterns.WindowsApplication.Model;

namespace ZsutPw.Patterns.WindowsApplication.View
{
    public class AppointmentWithNamesDtoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var appointmentWithNamesDto = (AppointmentWithNamesDto) value;

            return string.Format("[Appointment] Patient: {0} {1}, Doctor: {2} {3}, Date: {4}, Description: {5}", appointmentWithNamesDto.patientName, appointmentWithNamesDto.patientSurname, appointmentWithNamesDto.doctorName, appointmentWithNamesDto.doctorSurname, appointmentWithNamesDto.dateOfAppointment, appointmentWithNamesDto.description);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}