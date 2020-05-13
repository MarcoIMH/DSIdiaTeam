using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Page4lv : Page
    {
        public ObservableCollection<ShopItem> MotorShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<ShopItem> BodyWorkShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<ShopItem> WheelShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<ShopItem> ColorShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<ShopItem> LightShopItems { get; } = new ObservableCollection<ShopItem>();

        public Page4lv()
        {
            this.InitializeComponent();

            chargeListItems();
        }

        private void chargeListItems()
        {
            if (MotorShopItems != null)
                foreach (ShopItem ms in ShopModel.GetAllMotorItems())
                    MotorShopItems.Add(ms);

            if (BodyWorkShopItems != null)
                foreach (ShopItem bs in ShopModel.GetAllBodyWorkItems())
                    BodyWorkShopItems.Add(bs);

            if (WheelShopItems != null)
                foreach (ShopItem ws in ShopModel.GetAllWheelItems())
                    WheelShopItems.Add(ws);

            if (ColorShopItems != null)
                foreach (ShopItem cs in ShopModel.GetAllColorItems())
                    ColorShopItems.Add(cs);

            if (LightShopItems != null)
                foreach (ShopItem ls in ShopModel.GetAllLightItems())
                    LightShopItems.Add(ls);
        }

        private void motorShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = MotorShopItems;
        }

        private void bodyWorkShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = BodyWorkShopItems;
        }

        private void wheelShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = WheelShopItems;
        }

        private void colorShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = ColorShopItems;
        }

        private void lightShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = LightShopItems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void ShopSizeChanged(object sender, SizeChangedEventArgs e)
        {  
            //Row 0
            ExitButton.Height = Shop.RowDefinitions.ElementAt(0).ActualHeight;

            //Row 1
            ShopSectionsGrid.Height = Shop.RowDefinitions.ElementAt(1).ActualHeight * 0.9;
            CarImage.Height = Shop.RowDefinitions.ElementAt(1).ActualHeight;

            //Row 2
            BuyButton.Height = Shop.RowDefinitions.ElementAt(2).ActualHeight;

            //Row3
            GoldStackPanel.Width = Shop.ColumnDefinitions.ElementAt(0).ActualWidth;
            Gold.Width = Shop.RowDefinitions.ElementAt(3).ActualHeight * 0.15;
            UserGold.Width = Shop.RowDefinitions.ElementAt(3).ActualHeight * 0.17;

            IconStackPanel.Width = Shop.ColumnDefinitions.ElementAt(2).ActualWidth * 0.9;
            IconStackPanel.Height = Shop.RowDefinitions.ElementAt(3).ActualHeight * 0.9;

            MotorIcon.Width = MotorIcon.Height = IconStackPanel.Width / 6;
            BodyWorkIcon.Width = MotorIcon.Height = IconStackPanel.Width / 6;
            WheelIcon.Width = MotorIcon.Height = IconStackPanel.Width / 6;
            ColorIcon.Width = MotorIcon.Height = IconStackPanel.Width / 6;
            LightIcon.Width = MotorIcon.Height = IconStackPanel.Width / 6;
        }

        private void ShopSelectedItem(object sender, ItemClickEventArgs e)
        {
            //(e.OriginalSource as StackPanel).Background = Windows.UI.Xaml.Media.Brush.OpacityProperty           
        }

        private void Gold_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
