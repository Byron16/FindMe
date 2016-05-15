using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace FindMe_App
{
    public partial class denuncias : PhoneApplicationPage
    {
        PhoneCallTask call = new PhoneCallTask();

        public denuncias()
        {
            InitializeComponent();
        }


        private void btnpolicia_Click(object sender, RoutedEventArgs e)
        {
            call.PhoneNumber = "101"; 
            call.DisplayName = "Policia   ";
            call.Show();
        }

        private void btndinased1_Click(object sender, RoutedEventArgs e)
        {
            call.PhoneNumber = "032923420"; //tbldinased1.text
            call.DisplayName = "Dinased  ";
            call.Show();
        }

        private void btndinased2_Click(object sender, RoutedEventArgs e)
        {
            call.PhoneNumber = "032263495";
            call.DisplayName = "Dinased  ";
            call.Show();
        }

        private void btnecu_Click(object sender, RoutedEventArgs e)
        {
            call.PhoneNumber = "911";
            call.DisplayName = "Ecu 911   ";
            call.Show();
        }

        private void btndelitos_Click(object sender, RoutedEventArgs e)
        {
            call.PhoneNumber = "1800335486";
            call.DisplayName = "1800-Delitos  ";
            call.Show();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            idiomapag();
        }

        public void idiomapag()
        {

            txbdenuncia.Text = "";

            if (Globales.lenguaje == "English")
            {
                txbdenuncia.Text = "Deputy Minister of Internal Security , Javier Cordova, underscores the commitment of Fund of State and the National Police to solve all cases. To do this, urges citizens to know of any case of disappearance, to report on the website of the Ministry of Interior. This service is free and you should report immediately to the National Police to respond and have positive results.";
                pvtinfo.Header = "Info";
                pvttelef.Header = "Phone";
            }
            else
            {
                txbdenuncia.Text = "El viceministro de Seguridad Interna, Javier Córdova, recalca el compromiso de la Cartera de Estado y de la Policía Nacional para resolver todos los casos.       Para ello, pide a la ciudadanía que conoce algún caso de desaparición, lo denuncien en la página web del Ministerio del Interior. Este servicio es gratuito y debe informarlo de forma inmediata para que la Policía Nacional pueda responder y tener resultados positivos.";
                pvtinfo.Header = "Info";
                pvttelef.Header = "Telef";
            }
        }
    }
}