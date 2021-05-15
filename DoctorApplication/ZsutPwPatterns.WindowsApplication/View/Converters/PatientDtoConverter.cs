using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using ZsutPw.Patterns.WindowsApplication.Model.Data;

namespace ZsutPw.Patterns.WindowsApplication.View.Converters
{
    public class PatientDtoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var patientDto = (PatientsShortDto)value;
            return string.Format("Patient {0}, Name: {1}, Surname: {2}", patientDto.PatientId, patientDto.Name, patientDto.Surname);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
