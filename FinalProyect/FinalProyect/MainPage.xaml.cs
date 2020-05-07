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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinalProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ladron.Width = ladron.Height = main_grid.RowDefinitions.ElementAt(1).ActualHeight;
            policia.Width = policia.Height = main_grid.RowDefinitions.ElementAt(1).ActualHeight;
        }

        private void popUp_grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //stackPanel_checkButton.Width = stackPanel_checkButton.Height = check.Width = check.Height = popUp_grid.RowDefinitions.ElementAt(2).ActualHeight / 5;
            stackPanel_acceptButton.Width =  stackPanel_acceptButton.Height = accept.Width = accept.Height = popUp_grid.RowDefinitions.ElementAt(2).ActualHeight / 2.5; 
        }

        private void info_grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            stackpanel_joinButton.Width = join_button.Width = info_grid.ColumnDefinitions.ElementAt(1).ActualWidth * 4 / 5;
            stackpanel_joinButton.Height = join_button.Height = info_grid.RowDefinitions.ElementAt(2).ActualHeight * 3 / 5;
        }

        private void accept_Click(object sender, RoutedEventArgs e)
        {
            popUp_border.Visibility = Visibility.Collapsed;
            policia.IsEnabled = true;
            ladron.IsEnabled = true;
        }

        private void ladron_Click(object sender, RoutedEventArgs e)
        {
            ladron_image.Opacity = 1;
            policia_image.Opacity = 0.6;
            info_title.Text = "ROBBER";
            info_resumen.Text = "Steal, escape, and dont let the cops take you. Run away in an epic display of talent. But look out, they've got some tricks . . .";
        }

        private void policia_Click(object sender, RoutedEventArgs e)
        {
            policia_image.Opacity = 1;
            ladron_image.Opacity = 0.6;
            info_title.Text = "COP";
            info_resumen.Text = "Catch those thieves and bring them down to Hell. Work with your teammates, any help is needed against them . . .";
        }

        private void join_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }
    }
}
