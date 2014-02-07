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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//PanoramaPage1.xaml", UriKind.Relative));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//PanoramaPage3.xaml", UriKind.Relative));
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//Page77.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//PanoramaPage5.xaml", UriKind.Relative));
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This application is about travelling Varanasi and if you have any queries contact me at konvictedkrash@gmail.com", "HELP", MessageBoxButton.OK);
       
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//PanoramaPage7.xaml", UriKind.Relative));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//Page2.xaml", UriKind.Relative));
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//PanoramaPage8.xaml", UriKind.Relative));

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        
        
    }
}