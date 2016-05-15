using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FindMe_App
{
    public partial class personas : PhoneApplicationPage
    {
        public personas()
        {
            InitializeComponent();
        }

        private void txbpersonas_Loaded(object sender, RoutedEventArgs e)
        {
            idiomapag();
        }
        public void idiomapag()
        {
            txbpersonas.Text="";

            if (Globales.lenguaje == "English")
            {
                txbpersonas.Text = "People";
            }
            else
            {
                txbpersonas.Text = "Personas";
            }
        }
    }
}