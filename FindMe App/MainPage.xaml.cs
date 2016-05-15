using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FindMe_App.Resources;

namespace FindMe_App
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {

            if ((Convert.ToBoolean(rbtnes.IsChecked))==false && (Convert.ToBoolean(rbtnen.IsChecked))==false)
            {
                MessageBox.Show("Choose one language / Seleccione un lenguaje");
            }
            else
            {
                if (Convert.ToBoolean(rbtnes.IsChecked)) 
                {
                    Globales.lenguaje = rbtnes.Content.ToString();
                    NavigationService.Navigate(new Uri("/configuracion.xaml", UriKind.Relative));
                }
                else
                {
                    Globales.lenguaje = rbtnen.Content.ToString();
                    NavigationService.Navigate(new Uri("/configuracion.xaml", UriKind.Relative));
                }

            }
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
           intro.Begin();
        }
    }
}