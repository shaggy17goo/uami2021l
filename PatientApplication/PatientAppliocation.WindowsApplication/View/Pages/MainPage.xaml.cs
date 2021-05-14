//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace ZsutPw.Patterns.WindowsApplication.View
{
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Runtime.InteropServices.WindowsRuntime;

  using System.ComponentModel;

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
  using ZsutPwPatterns.WindowsApplication.View.Pages;

    public sealed partial class MainPage : Page
  {
    public IData Model { get; private set; }

    public IController Controller { get; private set; }

    public MainPage( )
    {
      this.InitializeComponent();

      IEventDispatcher dispatcher = new EventDispatcher( ) as IEventDispatcher;

      this.Controller = ControllerFactory.GetController( dispatcher );

      this.Model = this.Controller.Model as IData;

      this.DataContext = this.Controller;
    }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(DoctorsDataPage));
        }
        
        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {

            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                switch (item.Tag.ToString())
                {
                    case "page1":
                        ContentFrame.Navigate(typeof(DoctorsDataPage));
                        break;
                    case "page2":
                        ContentFrame.Navigate(typeof(DoctorDataPage));
                        break;
                    case "page3":
                        ContentFrame.Navigate(typeof(PatientDataPage));
                        break;
                    case "page4":
                        ContentFrame.Navigate(typeof(AppointmentsHistoryPage));
                        break;
                    case "page5":
                        ContentFrame.Navigate(typeof(FutureAppointmentsPage));
                        break;
                }
            }
        }
    }
}
