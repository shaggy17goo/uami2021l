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
            return string.Format("Appointment date: {0} with patient {1} {2}", appointmentDto.DateOfAppointment, appointmentDto.PatientName, appointmentDto.PatientSurname);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
