using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using System.Windows.Media;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;
//using Windows.Devices.Geolocation; 
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Controls;
using Microsoft.Phone.Shell;
using System.Threading;

namespace FindMe_App
{

    public partial class rasgos : PhoneApplicationPage
    {
        CameraCaptureTask foto = new CameraCaptureTask();
        PhotoChooserTask selecfoto = new PhotoChooserTask();
        BitmapImage bmp = new BitmapImage();
        bool sw = false;
        //Geoposition geopositionsend = null;
        
        public rasgos()
        {
            InitializeComponent();
            foto.Completed += new EventHandler<PhotoResult>(fotoyselec_Completed);
            selecfoto.Completed += new EventHandler<PhotoResult>(fotoyselec_Completed);

        }

        private void fotoyselec_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                bmp.SetSource(e.ChosenPhoto);
                imagen.Source = bmp;
                imagen.Stretch = Stretch.Uniform;

            }
        }

        /*  private void guardarimagen()
          {
              try
              {
                  // Crea un nombre de archivo para el archivo JPEG en el almacenamiento aislado.
                  String tempJPEG = "TempJPEG";
                  // Crea el almacenamiento virtual y el stream del archivo. Compruebe si hay archivos duplicados tempJPEG.
                  var myStore = IsolatedStorageFile.GetUserStoreForApplication();
                  if (myStore.FileExists(tempJPEG))
                  {
                      myStore.DeleteFile(tempJPEG);
                  }

              }
          }*/

        
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string cam = "";
            if (NavigationContext.QueryString.TryGetValue("cam", out cam))
            {
                if (cam == "s")
                {
                    sw = true;
                }
            }
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            if (sw == true)
            {
                foto.Show();
            }

            idiomapag();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }

        private void btngaleria_Click(object sender, RoutedEventArgs e)
        {
            selecfoto.Show();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (sw == true)
            {
                if (Globales.lenguaje == "English")
                {
                    MessageBox.Show("Thanks for supporting people in need \n\n Your image and attachments will be sent to the National Police closer, Ecu 911 and Their Families", "FindMe", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show("Gracias por apoyar a las personas necesitadas \n\n Tu imagen y los datos adjuntos seran enviadas a la Policia Nacional mas cerca, Ecu 911 y a sus Familiares ", "FindMe", MessageBoxButton.OK);
                } 
                NavigationService.Navigate(new Uri("/menu.xaml", UriKind.Relative));

                EmailComposeTask task = new EmailComposeTask();
                task.To = "mauro-b91@hotmail.com";
                task.Subject = "Urgente-FindMe";
               // task.Body = "Posible Coincidencia personal \n latitud: " + Convert.ToString(geopositionsend.Coordinate.Latitude+" LAtitud:"+Convert.ToString(geopositionsend.Coordinate.Longitude));
                task.Show();
            }

        }

      public void idiomapag()
        {

           txbcoincidencias.Text = "";
           btnenviar.Text = "";
           btngaleria.Content = "";

            if (Globales.lenguaje == "English")
            {
                txbcoincidencias.Text = "Matches";
                btnenviar.Text = "send";
                btngaleria.Content = "Gallery";
            }
            else
            {
                txbcoincidencias.Text = "Coincidencias";
                btnenviar.Text = "enviar";
                btngaleria.Content = "Galeria";
            }
        }

    }
}