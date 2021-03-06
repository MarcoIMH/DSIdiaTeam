﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Gaming.Input.ForceFeedback;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinalProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    /// 
    enum Section { motor, bodywork, wheel, color, light};

    public sealed partial class Page4lv : Page
    {
        public ObservableCollection<ShopItem> MotorShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<ShopItem> BodyWorkShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<ShopItem> WheelShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<ShopItem> ColorShopItems { get; } = new ObservableCollection<ShopItem>();
        public ObservableCollection<ShopItem> LightShopItems { get; } = new ObservableCollection<ShopItem>();

        ShopItem itemClicked;
        int goldRemaining = 1230;
        Section section = Section.motor;
        bool itemColorBuyed = false;
        SolidColorBrush lastColorBuyed;

        public Page4lv()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;

            UserGold.Text =  goldRemaining.ToString();

            chargeListItems();
        }

        private void chargeListItems()
        {
            if (MotorShopItems != null)
                foreach (ShopItem ms in ShopModel.GetAllMotorItems())
                {
                    setItemState(ms);  
                    MotorShopItems.Add(ms);
                }
                    

            if (BodyWorkShopItems != null)
                foreach (ShopItem bs in ShopModel.GetAllBodyWorkItems())
                {
                    setItemState(bs);
                    BodyWorkShopItems.Add(bs);
                }
                    

            if (WheelShopItems != null)
                foreach (ShopItem ws in ShopModel.GetAllWheelItems())
                {
                    setItemState(ws);
                    WheelShopItems.Add(ws);
                }
                    

            if (ColorShopItems != null)
                foreach (ShopItem cs in ShopModel.GetAllColorItems())
                {
                    setItemState(cs);
                    ColorShopItems.Add(cs);
                }
                    

            if (LightShopItems != null)
                foreach (ShopItem ls in ShopModel.GetAllLightItems())
                {
                    setItemState(ls);
                    LightShopItems.Add(ls);
                }
                    
        }

        private void setItemState(ShopItem item)
        {
            if (item.State == ItemStates.purchased)
            {
                item.BackgroundColor = new SolidColorBrush(Colors.Green);
                item.ItemOpacity = 0.5;
            }else if(item.Price <= goldRemaining)
            {
                item.State = ItemStates.canBePurchased;
                item.BackgroundColor = new SolidColorBrush(Colors.Yellow);
            }
            else
            {
                item.State = ItemStates.cantBePurchased;
                item.BackgroundColor = new SolidColorBrush(Colors.Gray);
            }
        }

        private void motorShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = MotorShopItems;
            section = Section.motor;
            ResetCar();
        }

        private void bodyWorkShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = BodyWorkShopItems;
            section = Section.bodywork;
            ResetCar();
        }

        private void wheelShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = WheelShopItems;
            section = Section.wheel;
            ResetCar();
        }

        private void colorShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = ColorShopItems;
            section = Section.color;
            ResetCar();
        }

        private void lightShop(object sender, RoutedEventArgs e)
        {
            ShopSectionsGrid.ItemsSource = LightShopItems;
            section = Section.light;
            ResetCar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void ShopSizeChanged(object sender, SizeChangedEventArgs e)
        {
            //----------------------------------------------------------------------------------------------> Row 0
            //Exit Button
            ExitButton.Height = ExitButton.Width = Shop.RowDefinitions.ElementAt(0).ActualHeight;

            //----------------------------------------------------------------------------------------------> Row 1  
            //Car
            CarStackPanel.Width = Shop.ColumnDefinitions.ElementAt(0).ActualWidth * 0.9;
            CarStackPanel.Height = Shop.RowDefinitions.ElementAt(1).ActualHeight;

            CarImage.Width = CarStackPanel.Width *  0.9;
            CarImage.Height = CarStackPanel.Height;

            //ShopSections
            ShopSectionsGrid.Height = Shop.RowDefinitions.ElementAt(1).ActualHeight * 0.9;
            ShopSectionsGrid.Width = Shop.ColumnDefinitions.ElementAt(1).ActualWidth * 0.9;

            

            //----------------------------------------------------------------------------------------------> Row 2
            BuyButton.Height = Shop.RowDefinitions.ElementAt(2).ActualHeight * 0.9;
            BuyButton.Width = Shop.ColumnDefinitions.ElementAt(1).ActualWidth * 0.9;

            //----------------------------------------------------------------------------------------------> Row3
            //GoldPanel
            GoldStackPanel.Width = Shop.ColumnDefinitions.ElementAt(0).ActualWidth * 0.9;

            Gold.Width = GoldStackPanel.Width / 3;
            Gold.FontSize = Shop.RowDefinitions.ElementAt(3).ActualHeight * 0.5;

            UserGold.Width = GoldStackPanel.Width / 3;
            UserGold.FontSize = Shop.RowDefinitions.ElementAt(3).ActualHeight * 0.5;

            Dolar.Width = GoldStackPanel.Width / 3;
            Dolar.FontSize = Shop.RowDefinitions.ElementAt(3).ActualHeight * 0.5;

            //IconStackPanel
            IconStackPanel.Width = Shop.ColumnDefinitions.ElementAt(1).ActualWidth * 0.9;
            
            MotorIcon.Width =  IconStackPanel.Width / 6;
            BodyWorkIcon.Width = IconStackPanel.Width / 6;
            WheelIcon.Width =  IconStackPanel.Width / 6;
            ColorIcon.Width =  IconStackPanel.Width / 6;
            LightIcon.Width =  IconStackPanel.Width / 6;
        }

        private void ShopSelectedItem(object sender, ItemClickEventArgs e)
        {
            itemClicked = (ShopItem) e.ClickedItem;            

            if (section == Section.color)
            {
                switch (itemClicked.Type)
                {
                    case 0:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/purplecar.png"));
                            break;
                        }
                    case 1:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/cargreen.png")); 
                            break;
                        }
                    case 2:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/caryellow.png"));
                            break;
                        }
                    case 3:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/carblue.png"));
                            break;
                        }
                    case 4:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/carred.png"));
                            break;
                        }
                    case 5:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/carbrown.png"));
                            break;
                        }
                    case 6:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/carorange.png"));
                            break;
                        }
                    case 7:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/carwhite.png"));
                            break;
                        }
                    case 8:
                        {
                            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/carblack.png"));
                            break;
                        }
                }
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            if(itemClicked != null && itemClicked.State != ItemStates.purchased &&  itemClicked.Price <= goldRemaining)
            {
                UserGold.Text = (goldRemaining - itemClicked.Price).ToString();
                goldRemaining = goldRemaining - itemClicked.Price;
                itemClicked.Price = 0;
                itemClicked.BackgroundColor = new SolidColorBrush(Colors.Green);
                itemClicked.ItemOpacity = 0.5;

                if (section == Section.color)
                {
                    itemColorBuyed = true;
                }

                switch (section)
                {
                    case Section.motor:
                        wheelShop(sender, e);
                        motorShop(sender, e);
                        break;
                    case Section.bodywork:
                        wheelShop(sender, e);
                        bodyWorkShop(sender, e);
                        break;
                    case Section.wheel:
                        colorShop(sender, e);
                        wheelShop(sender, e);
                        break;
                    case Section.color:
                        wheelShop(sender, e);
                        colorShop(sender, e);
                        break;
                    case Section.light:
                        wheelShop(sender, e);
                        lightShop(sender, e);
                        break;
                }
            }
        }

        private void ResetCar()
        {
            if (!itemColorBuyed)
                CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Page4/car.png"));
        }
    }
}
