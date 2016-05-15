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
    public partial class configuracion : PhoneApplicationPage
    {
        public configuracion()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
           
            idiomapag();
            btnokconfig.IsEnabled = false;
            
        }
        private void datos()
        {
            if ((txbnombre.Text != "") && (txbapellido.Text != "") && (txbcedula.Text != "") && (txbtelefono.Text != "") && (txbdomicilio.Text != "") && (txbemail.Text != ""))
            {
                btnokconfig.IsEnabled = true;
            }
            else
            {
                btnokconfig.IsEnabled = false;
            }
        }

        private void btnokconfig_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }

        private void txbnombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            datos();
        }

        private void txbapellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            datos();
        }

        private void txbcedula_TextChanged(object sender, TextChangedEventArgs e)
        {
            datos();
        }

        private void txbtelefono_TextChanged(object sender, TextChangedEventArgs e)
        {
            datos();
        }

        private void txbdomicilio_TextChanged(object sender, TextChangedEventArgs e)
        {
            datos();
        }

        private void txbemail_TextChanged(object sender, TextChangedEventArgs e)
        {
            datos();
        }

        private void LayoutRoot_Unloaded(object sender, RoutedEventArgs e)
        {
            idiomapag();
        }


        public void idiomapag()
        {

            txbconfiguracion.Text = "";
            txtbllenar.Text ="";
            txtbnombre.Text = "";
            txtbapellido.Text = "";
            txtbci.Text = "";
            txtbtelefono.Text = "";
            txtbdomicilio.Text = "";
            txtbemail.Text = "";

            if (Globales.lenguaje == "English")
            {

                txbconfiguracion.Text = "Configuration";
                txtbllenar.Text = "Please fill out the following fields:";
                txtbnombre.Text = "Name:";
                txtbapellido.Text = "Last Name:";
                txtbci.Text = "I.D:";
                txtbtelefono.Text = "Telephone:";
                txtbdomicilio.Text = "Home:";
                txtbemail.Text = "e-mail:";
            }
            else
            {
                txbconfiguracion.Text = "Configuracion";
                txtbllenar.Text = "Por favor llena los siguientes campos:";
                txtbnombre.Text = "Nombre:";
                txtbapellido.Text = "Apellido:";
                txtbci.Text = "C.I:";
                txtbtelefono.Text = "Telefono:";
                txtbdomicilio.Text = "Domicilio:";
                txtbemail.Text = "e-mail:";
            }
        }


    }
}