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
    public partial class ayudanos : PhoneApplicationPage
    {
        public ayudanos()
        {
            InitializeComponent();
        }

        private void btnidea_Click(object sender, RoutedEventArgs e)
        {

            if (Globales.lenguaje == "English")
            {
                MessageBox.Show("Your idea been successfully sent to the creators of FindMe \n\n Thank you for helping", "Congratulation", MessageBoxButton.OK);
                               
            }
            else 
            {
                MessageBox.Show("Tu idea a sido enviada exitosamente a los creadores de FindMe \n\n GRACIAS por ayudarnos", "Felicidades", MessageBoxButton.OK);
            }
           
            NavigationService.Navigate(new Uri("/menu.xaml", UriKind.Relative));
           

        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            idiomapag();
            btnidea.IsEnabled = false;
        }

        public void idiomapag()
        {
            txbmensaje.Text = "";

            if (Globales.lenguaje == "English")
            {
                txbsugerencias.Text = "Suggestions";
                txbmensaje.Text = "This space is for public review , and thanks to it we can continue to grow. You can contribute with innovative ideas to further improve FindMe and rejoining more homes.";
                txbmax.Text = "Idea: (Limit 200 characteres)";
                btnidea.Content = "Send";
            }
            else
            {
                txbsugerencias.Text = "Sugerencias";
                txbmensaje.Text = "Este espacio es para la opinion ciudadana, ya que gracias a ella podremos seguir creciendo. Tu puedes aportar con ideas innovadoras para seguir mejorando FindMe y volver a unir mas hogares";
                txbmax.Text = "Idea: ( Max 200 Caracteres )";
                btnidea.Content = "Enviar";
            }
        }

        private void txbidea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbidea.Text!="")
            {
             btnidea.IsEnabled=true;
            }
        }

    }
}