using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Animation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace AplicacionWP
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private bool cambiado = false;

        public MainPage()
        {
            this.InitializeComponent();
        }



        private async void cambiaImagen(object sender, RoutedEventArgs e)
        {
            if (cambiado == false && (cambiaUPM.GetCurrentState() != ClockState.Active && cambiaETSISI.GetCurrentState() != ClockState.Active))
            {
                cambiaUPM.Begin();
                cambiado = true;
            } else if (cambiado == true && (cambiaETSISI.GetCurrentState() != ClockState.Active && cambiaUPM.GetCurrentState() != ClockState.Active))
            {
                cambiaETSISI.Begin();
                cambiado = false;
            }
            
            //Thickness posNuevaMarta, posNuevaAlex, posNuevaIvan;
            //BitmapImage img;
            //if (cambiado == false)
            //{
            //    img = new BitmapImage(new Uri("ms-appx:///Assets/etsisi.png"));
            //    logo.Source = img;
            //    posNuevaMarta = new Thickness(96, 425, 0, 0);
            //    textMarta.Margin = posNuevaMarta;
            //    posNuevaAlex = new Thickness(96, 286, 0, 0);
            //    textAlejandro.Margin = posNuevaAlex;
            //    posNuevaIvan = new Thickness(96, 356, 0, 0);
            //    textIvan.Margin = posNuevaIvan;
            //    cambiado = true;
            //}
            //else
            //{
            //    img = new BitmapImage(new Uri("ms-appx:///Assets/upm.gif"));
            //    logo.Source = img;
            //    posNuevaMarta = new Thickness(96, 356, 0, 0);
            //    textMarta.Margin = posNuevaMarta;
            //    posNuevaAlex = new Thickness(96, 425, 0, 0);
            //    textAlejandro.Margin = posNuevaAlex;
            //    posNuevaIvan = new Thickness(96, 286, 0, 0);
            //    textIvan.Margin = posNuevaIvan;
            //    cambiado = false;
            //}
        }
    }
}
