using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace FindMe_App
{
    public partial class Menu : PhoneApplicationPage
    {
        // variables a utilizar
        // ProgressIndicator pi;

        public Menu()
        {
            InitializeComponent();
        }

        private void btncoincidencias_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/rasgos.xaml", UriKind.Relative));

        }

        private void btnlocalizacion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/localizacion.xaml", UriKind.Relative));
        }

        private void btndenuncias_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/denuncias.xaml", UriKind.Relative));
        }

        private void btnfoto_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/rasgos.xaml?cam=s", UriKind.Relative));

        }

        private void btnpersonas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/personas.xaml", UriKind.Relative));
        }

        private void btnsuge_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ayudanos.xaml", UriKind.Relative));
        }


        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {
            idiomapag();
        }


        public void idiomapag()
        {

            txbfoto.Text = "";
            txbpersonas.Text = "";
            txbcoin.Text = "";
            txbloca.Text = "";
            txbdenun.Text = "";
            txbsuge.Text = "";


            if (Globales.lenguaje == "English")
            {
                txbfoto.Text = "Photo";
                txbpersonas.Text = "People";
                txbcoin.Text = "Matches";
                txbloca.Text = "Location";
                txbdenun.Text = "Complaints";
                txbsuge.Text = "Suggestions";
                
            }
            else
            {
                txbfoto.Text = "Foto";
                txbpersonas.Text = "Personas";
                txbcoin.Text = "Coincidencias";
                txbloca.Text = "Localización";
                txbdenun.Text = "Denuncias";
                txbsuge.Text = "Sugerencias";
                
            }
        }

        private void btntwitter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estimado Usuario por el momento esta red social se encuentra en construccion, lamentamos las molestias", "Twitter", MessageBoxButton.OK); 
        }

        private void btnfacebook_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estimado Usuario por el momento esta red social se encuentra en construccion, lamentamos las molestias", "Facebook", MessageBoxButton.OK);
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/configuracion.xaml", UriKind.Relative));
        }
    }
}