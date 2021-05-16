using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


using ZsutPw.Patterns.WindowsApplication.Controller;
using ZsutPw.Patterns.WindowsApplication.Model;
using ZsutPw.Patterns.WindowsApplication.Utilities;
using ZsutPw.Patterns.WindowsApplication.View.Converters;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ZsutPw.Patterns.WindowsApplication.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {

        public IData Model { get; private set; }

        public IController Controller { get; private set; }
        public HomePage()
        {
            this.InitializeComponent();

            IEventDispatcher dispatcher = new EventDispatcher() as IEventDispatcher;

            this.Controller = ControllerFactory.GetController(dispatcher);

            this.Model = this.Controller.Model as IData;

            this.DataContext = this.Controller;
        }

        private void ToPatients_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Patients));
        }
        private void ToTimetable_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Timetable));
        }
        private void ToAppointments_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Appointments));
        }
    }
}
