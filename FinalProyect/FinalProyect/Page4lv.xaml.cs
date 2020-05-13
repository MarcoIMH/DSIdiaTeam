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
            ShopGrid.ItemsSource = MotorShopItems;
        }

        private void bodyWorkShop(object sender, RoutedEventArgs e)
        {
            ShopGrid.ItemsSource = BodyWorkShopItems;
        }

        private void wheelShop(object sender, RoutedEventArgs e)
        {
            ShopGrid.ItemsSource = WheelShopItems;
        }

        private void colorShop(object sender, RoutedEventArgs e)
        {
            ShopGrid.ItemsSource = ColorShopItems;
        }

        private void lightShop(object sender, RoutedEventArgs e)
        {
            ShopGrid.ItemsSource = LightShopItems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void ShopSizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void probando(object sender, ItemClickEventArgs e)
        {
            //(e.OriginalSource as StackPanel).Background = Windows.UI.Xaml.Media.Brush.OpacityProperty           
        }
    }
}
