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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace FinalProyect
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void gridSizeChanged(object sender, SizeChangedEventArgs e)
        {
            botonSalir.Height = botonSalir.Width = mainGrid.RowDefinitions.ElementAt(0).ActualHeight;
            botonInfo.Height = botonInfo.Width = mainGrid.RowDefinitions.ElementAt(0).ActualHeight * 0.5;
            botonAjustes.Height = botonAjustes.Width = mainGrid.RowDefinitions.ElementAt(0).ActualHeight;

            BarraGuerra.Width = ((Frame)Window.Current.Content).ActualWidth * 0.4;

            botonTaller.Height = botonTaller.Width = mainGrid.RowDefinitions.ElementAt(1).ActualHeight * 0.3;
            botonPerfil.Height = botonPerfil.Width = mainGrid.RowDefinitions.ElementAt(1).ActualHeight * 0.3;

            botonJugar.Height = mainGrid.RowDefinitions.ElementAt(1).ActualHeight * 0.3;
            botonJugar.Width = botonJugar.Height * 1.5;
        }
    }
}
