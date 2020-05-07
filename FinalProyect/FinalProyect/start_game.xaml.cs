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
    public sealed partial class start_game : Page
    {
        public start_game()
        {
            this.InitializeComponent();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            exit.Width = grid_.ColumnDefinitions.ElementAt(0).ActualWidth * 2 / 3;
            exit.Height = grid_.RowDefinitions.ElementAt(0).ActualHeight;

            user1.Width = user1.Height = grid_.RowDefinitions.ElementAt(1).ActualHeight;
            user2.Width = user2.Height = grid_.RowDefinitions.ElementAt(1).ActualHeight;
            user3.Width = user3.Height = grid_.RowDefinitions.ElementAt(1).ActualHeight;
            user4.Width = user4.Height = grid_.RowDefinitions.ElementAt(1).ActualHeight;

            chat.MaxHeight = grid_.RowDefinitions.ElementAt(3).ActualHeight * 2 / 3;
        }
    }
}
