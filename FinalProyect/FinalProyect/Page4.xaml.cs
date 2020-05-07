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
    public sealed partial class Page4 : Page
    {
        public Page4()
        {
            this.InitializeComponent();
        }

        private void motorShop(object sender, RoutedEventArgs e)
        {
            motorShopPanel.Visibility = Visibility.Visible;
            bodyWorkShopPanel.Visibility = Visibility.Collapsed;
            wheelShopPanel.Visibility = Visibility.Collapsed;
            colorShopPanel.Visibility = Visibility.Collapsed;
            lightShopPanel.Visibility = Visibility.Collapsed;
        }

        private void bodyWorkShop(object sender, RoutedEventArgs e)
        {
            motorShopPanel.Visibility = Visibility.Collapsed;
            bodyWorkShopPanel.Visibility = Visibility.Visible;
            wheelShopPanel.Visibility = Visibility.Collapsed;
            colorShopPanel.Visibility = Visibility.Collapsed;
            lightShopPanel.Visibility = Visibility.Collapsed;
        }

        private void wheelShop(object sender, RoutedEventArgs e)
        {
            motorShopPanel.Visibility = Visibility.Collapsed;
            bodyWorkShopPanel.Visibility = Visibility.Collapsed;
            wheelShopPanel.Visibility = Visibility.Visible;
            colorShopPanel.Visibility = Visibility.Collapsed;
            lightShopPanel.Visibility = Visibility.Collapsed;
        }

        private void colorShop(object sender, RoutedEventArgs e)
        {
            motorShopPanel.Visibility = Visibility.Collapsed;
            bodyWorkShopPanel.Visibility = Visibility.Collapsed;
            wheelShopPanel.Visibility = Visibility.Collapsed;
            colorShopPanel.Visibility = Visibility.Visible;
            lightShopPanel.Visibility = Visibility.Collapsed;
        }

        private void lightShop(object sender, RoutedEventArgs e)
        {
            motorShopPanel.Visibility = Visibility.Collapsed;
            bodyWorkShopPanel.Visibility = Visibility.Collapsed;
            wheelShopPanel.Visibility = Visibility.Collapsed;
            colorShopPanel.Visibility = Visibility.Collapsed;
            lightShopPanel.Visibility = Visibility.Visible;
        }
    }
}
