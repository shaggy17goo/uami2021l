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

            return String.Format("{0},{1}", doctorDto.name, doctorDto.surname);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
