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
    public partial class Page4 : PhoneApplicationPage
    {
        public Page4()
        {
            InitializeComponent();
            webBrowser1.Navigate(new Uri("http://hotelidealtower.com", UriKind.Absolute));
        }

        private void PageTitle_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}