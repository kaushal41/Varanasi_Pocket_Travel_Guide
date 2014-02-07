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

namespace Travelling_varanasi
{
    public partial class Page3 : PhoneApplicationPage
    {
        public Page3()
        {
            InitializeComponent();
            webBrowser1.Navigate(new Uri("http://www.clarkshotels.com", UriKind.Absolute));
             
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void webBrowser1_DoubleTap(object sender, GestureEventArgs e)
        {
            
        }

        private void webBrowser1_Hold(object sender, GestureEventArgs e)
        {
            
        }
    }
}