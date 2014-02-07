 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Travelling_Varanasi
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Application.Current.Host.Settings.EnableFrameRateCounter = false;

        }

        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This application is about travelling Varanasi and if you have any queries contact me at konvictedkrash@gmail.com","HELP", MessageBoxButton.OK);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//Page1.xaml", UriKind.Relative));
        }
        
    }
}