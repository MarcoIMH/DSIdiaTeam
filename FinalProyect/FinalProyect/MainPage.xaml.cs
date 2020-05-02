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

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ladron.Width = ladron.Height = main_grid.RowDefinitions.ElementAt(1).ActualHeight;
            policia.Width = policia.Height = main_grid.RowDefinitions.ElementAt(1).ActualHeight;
            info.Width = main_grid.ColumnDefinitions.ElementAt(1).ActualWidth;
            info.Height = main_grid.RowDefinitions.ElementAt(3).ActualHeight;

            accept.Width = accept.Height = main_grid.RowDefinitions.ElementAt(1).ActualHeight * 2/3;
            check.Width = check.Height = main_grid.RowDefinitions.ElementAt(1).ActualHeight / 3;
        }

        private void popUp_grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            stackPanel_checkButton.Width = stackPanel_checkButton.Height = popUp_grid.RowDefinitions.ElementAt(2).ActualHeight / 5;
            stackPanel_acceptButton.Width = stackPanel_acceptButton.Height = popUp_grid.RowDefinitions.ElementAt(2).ActualHeight / 2.5;
        }
    }
}
