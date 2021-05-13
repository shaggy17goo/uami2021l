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

            return string.Format("{0} at {1}", appointmentWithNamesDto.doctorName, appointmentWithNamesDto.patientName);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}