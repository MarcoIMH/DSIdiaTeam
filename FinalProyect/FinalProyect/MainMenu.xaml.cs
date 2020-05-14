using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace FinalProyect
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        public ObservableCollection<Mision> ListaMisiones { get; } = new ObservableCollection<Mision>();
        public ObservableCollection<Evento> ListaEventos { get; } = new ObservableCollection<Evento>();

        public Jugador player;

        public MainMenu()
        {
            this.InitializeComponent();

            if (ListaMisiones != null)
                foreach (Mision m in Model.GetAllMisions())
                {
                    ListaMisiones.Add(m);
                }

            if (ListaEventos != null)
                foreach (Evento e in EventModel.GetAllEvents())
                {
                    ListaEventos.Add(e);
                }

            player = new Jugador("Nico", bando.policia, 50, 35);
            PlayerName.Text = player.Nombre;
            PlayerBand.Text = player.Bando;
            playerPlayed.Text = player.PartidasJugadas.ToString();
            playerWined.Text = player.PartidasGanadas.ToString();
        }

        private void gridSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Salir.Width = Salir.Height = mainGrid.RowDefinitions.ElementAt(0).ActualHeight;
            botonSalir.Width = botonSalir.Height = mainGrid.RowDefinitions.ElementAt(0).ActualHeight;
            botonInfo.Height = botonInfo.Width = mainGrid.RowDefinitions.ElementAt(0).ActualHeight * 0.5;
            botonAjustes.Height = botonAjustes.Width = mainGrid.RowDefinitions.ElementAt(0).ActualHeight;

            BarraGuerra.Width = ((Frame)Window.Current.Content).ActualWidth * 0.4;
            BarraGuerra.Height = botonSalir.Width = mainGrid.RowDefinitions.ElementAt(0).ActualHeight * 0.5;

            botonTaller.Height = botonTaller.Width = mainGrid.RowDefinitions.ElementAt(1).ActualHeight * 0.3;
            botonPerfil.Height = botonPerfil.Width = mainGrid.RowDefinitions.ElementAt(1).ActualHeight * 0.3;

            botonJugar.Height = mainGrid.RowDefinitions.ElementAt(1).ActualHeight * 0.25;
            botonJugar.Width = ((Frame)Window.Current.Content).ActualWidth * 0.15;
            botonJugar.MinWidth = textoJugar.ActualWidth + 20;
            botonJugar.MinHeight = textoJugar.ActualHeight + 20;

            listaEventos.Width = ((Frame)Window.Current.Content).ActualWidth * 0.85;

            PerfilPopUp.Height = mainGrid.RowDefinitions.ElementAt(1).ActualHeight;
            PerfilPopUp.Width = ((Frame)Window.Current.Content).ActualWidth * 0.5;

            policiaIcon.Height = mainGrid.RowDefinitions.ElementAt(0).ActualHeight * 0.7;
            policiaIcon.Width = ((Frame)Window.Current.Content).ActualWidth * 0.15;
            policiaPoints.FontSize = mainGrid.RowDefinitions.ElementAt(0).ActualHeight * 0.2;

            ladronIcon.Height = mainGrid.RowDefinitions.ElementAt(0).ActualHeight * 0.7;
            ladronIcon.Width = ((Frame)Window.Current.Content).ActualWidth * 0.15;
            ladronPoints.FontSize = mainGrid.RowDefinitions.ElementAt(0).ActualHeight * 0.2;
        }

        private void perfilClicked(object sender, RoutedEventArgs e)
        {
            if (PerfilPopUp.Visibility == Visibility.Collapsed)
            {
                PerfilPopUp.Visibility = Visibility.Visible;
            }
            else PerfilPopUp.Visibility = Visibility.Collapsed;
        }

        private void botonJugar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(start_game));
        }

        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void botonTaller_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page4lv));
        }

        private void botonAjustes_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page3));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if ((bando)e.Parameter == bando.policia)
            {
                PlayerBand.Text = "Policía";
                player.Bando = "Policía";
            }
            else
            {
                PlayerBand.Text = "Ladrones";
                player.Bando = "Ladrones";
                Fondo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Imagenes/fondo2.jpg"));
            }
        }
    }
}
