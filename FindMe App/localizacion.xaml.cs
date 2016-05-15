using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Device.Location;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Phone.Maps;
using Windows.Devices.Geolocation; //librerias
using Microsoft.Phone.Maps.Controls;
using System.Windows.Media;


namespace FindMe_App
{
    public partial class localizacion : PhoneApplicationPage
    {

        Dictionary<int, GeoCoordinate> policelist;
        
        
        
        // Constructor
        public localizacion()
        {
            InitializeComponent();
            policelist= new Dictionary<int,GeoCoordinate>();
            policelist.Add(1, new GeoCoordinate(-01.6449, -078.6737));
            policelist.Add(2, new GeoCoordinate(-01.6621, -078.6627));
            this.Loaded += new RoutedEventHandler(localizacion_Loaded);
        }

        void localizacion_Loaded(object sender, RoutedEventArgs e)
        {
            idioma();
            SystemTray.ProgressIndicator = new ProgressIndicator();

            //estaciones de policia
            foreach (int key in this.policelist.Keys)
            {
                //var aPushpin = CreatePushpin();

                Grid gridpolice = new Grid();
                gridpolice.Width = 50;
                gridpolice.Height = 65;
                ImageBrush brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("/imagenes/police.png", UriKind.Relative));
                gridpolice.Background = brush;
                
                //Cremos un MapOverlay y agregamos el Pushpin con sus respectivas propiedades como coordenadas
                MapOverlay overlaypolice = new MapOverlay();
                overlaypolice.Content = gridpolice;
                overlaypolice.GeoCoordinate = this.policelist[key];
                overlaypolice.PositionOrigin = new Point(0, 0.5);
                
                //creamos un maplayer y añadimos el mapoverlay a este
                MapLayer layerpolice = new MapLayer();
                layerpolice.Add(overlaypolice);
                MyMap.Layers.Add(layerpolice);
            }
        }

        private void idioma()
        {
            txbgps.Text = "";
            txblatitud.Text = "";
            txblongitud.Text = "";
            txbestado.Text = "";
            txtestado.Text = "";
            txtlatitud.Text = "";
            txtlongitud.Text = "";

            if (Globales.lenguaje == "English")
            {
                txbgps.Text = "Localization";
                txtlatitud.Text = "Latitude:";
                txtlongitud.Text = "Longitude:";
                txtestado.Text = "Status:";
                btnyo.Text = "I";
            }
            else
            {
                txbgps.Text = "Localizacion";
                txtlatitud.Text = "Latitud:";
                txtlongitud.Text = "Longitud:";
                txtestado.Text = "Estado:";
                btnyo.Text = "Yo";
            }
        }


        private async void btnyo_Click(object sender, EventArgs e)
        {
            if (Globales.lenguaje=="English")
                txbestado.Text = "Loading.";
            else
                txbestado.Text = "Iniciando.";

            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;
            SetProgressIndicator(true);

            if (Globales.lenguaje == "English")
                SystemTray.ProgressIndicator.Text = "GPS Locator";
            else
                SystemTray.ProgressIndicator.Text = "Localizando GPS";
            

            try
            {
                Geoposition position =
                    await geolocator.GetGeopositionAsync(
                    TimeSpan.FromMinutes(1),
                    TimeSpan.FromSeconds(30));

                SystemTray.ProgressIndicator.Text = "Localizado";

                var gpsCoorCenter =
                    new GeoCoordinate(
                        position.Coordinate.Latitude,
                        position.Coordinate.Longitude);

                MyMap.Center = gpsCoorCenter;
                //MyMap.SetView = (gpsCoorCenter,17);
                MyMap.ZoomLevel = 17;
                SetProgressIndicator(false);

                txblatitud.Text = position.Coordinate.Latitude.ToString("0.00");
                txblongitud.Text = position.Coordinate.Longitude.ToString("0.00");
                txbestado.Text = "Listo";
                // Llamamos a la funcion de crear el pushpin y le mandamos la coordenada de nuestra posición
                DrawPushpin(gpsCoorCenter);
            }
            catch (UnauthorizedAccessException) {
                MessageBox.Show("Location is disable in phone settings.");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        private static void SetProgressIndicator(bool isVisible)
        {
            SystemTray.ProgressIndicator.IsIndeterminate = isVisible;
            SystemTray.ProgressIndicator.IsVisible = isVisible;
        }

        private void DrawPushpin(GeoCoordinate coord)
        {
            //creamos una variable y llamamos a la funcion que genera todo el gráfico
            var aPushpin = CreatePushpin();
            
            //Cremos un MapOverlay y agregamos el Pushpin con sus respectivas propiedades como coordenadas
            MapOverlay MyOverlay = new MapOverlay();
            MyOverlay.Content = aPushpin;
            MyOverlay.GeoCoordinate = coord;
            MyOverlay.PositionOrigin = new Point(0, 0.5);
                                  
            //creamos un maplayer y añadimos el mapoverlay a este
            MapLayer mylayer = new MapLayer();
            mylayer.Add(MyOverlay);
            MyMap.Layers.Add(mylayer);
            
        }

        private Grid CreatePushpin()
        {
            Grid MyGrid = new Grid();
            MyGrid.Width = 50;
            MyGrid.Height = 65;
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("/imagenes/pushping.png", UriKind.Relative));
            MyGrid.Background = brush;
            //MessageBox.Show("Mostrar su posicion actual.?");
           return MyGrid;
        }

    }
}