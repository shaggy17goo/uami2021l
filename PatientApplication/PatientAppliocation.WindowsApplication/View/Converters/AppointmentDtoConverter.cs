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
    public class AppointmentDtoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var appointmentDto = (AppointmentDto) value;

            return string.Format("{0} at {1}", appointmentDto.patientId, appointmentDto.doctorId);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}