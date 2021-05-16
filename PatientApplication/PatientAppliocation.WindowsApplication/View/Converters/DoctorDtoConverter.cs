namespace ZsutPw.Patterns.WindowsApplication.View
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using Windows.UI.Xaml.Data;
    using ZsutPw.Patterns.WindowsApplication.Dto;

    public class DoctorDtoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DoctorDto doctorDto= (DoctorDto)value;

            var certString = "";
            foreach(int cert in doctorDto.certifications)
            {
                certString += $"{cert}, ";
            }
            certString = certString.Remove(certString.Length - 2);
            return String.Format("[Doctor] Name: {0}, Surname: {1}, Certifications: {2}", doctorDto.name, doctorDto.surname, certString);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
