using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using ZsutPw.Patterns.WindowsApplication.Model.Data;

namespace ZsutPw.Patterns.WindowsApplication.View.Converters
{
    public class AppointmentsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var appointmentDto = (AppointmentsWithPatientNameDto) value;
            return string.Format("Patient {0}, appointment with doctor {1}", appointmentDto.PatientId, appointmentDto.DoctorId);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
