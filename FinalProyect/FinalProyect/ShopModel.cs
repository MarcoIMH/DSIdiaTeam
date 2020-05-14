using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;


namespace FinalProyect
{
    public enum ItemStates { canBePurchased, cantBePurchased, purchased, uncheked };

    public class Gold
    {
        public int TotalUserGold { get; set; }

        public Gold() { TotalUserGold = 1350; }
    }

    public class ShopItem
    {
        //public string BackgroundColor { get; set; }
        // Panel BackgroundColor { get; set; }
        public int Price { get; set; }
        public string Imagen {get;set;}
        public int Type { get; set; }
        public ItemStates State { get; set; }

        public ShopItem() {
            //BackgroundColor = "#60CCB4";
            //BackgroundColor = ColorPicker;
            Type = 0;
            State = ItemStates.uncheked;
        }
    }

    public class ShopModel
    {
        //-----------------------------------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------> MOTOR SHOP ITEMS <---------
        //-----------------------------------------------------------------------------------------------------------------
        public static List<ShopItem> MotorShopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Price = 120,
                Imagen = "Assets/Page4/m1.png",  
            },
            new ShopItem()
            {
                Price = 130,
                Imagen = "Assets/Page4/m2.png",
            },
            new ShopItem()
            {
                Price = 140,
                Imagen = "Assets/Page4/m3.png",
            },
            new ShopItem()
            {
                Price = 150,
                Imagen = "Assets/Page4/m4.png",
            },
            new ShopItem()
            {
                Price = 160,
                Imagen = "Assets/Page4/m5.png",
            },
            new ShopItem()
            {
                Price = 170,
                Imagen = "Assets/Page4/m6.png",
            },
            new ShopItem()
            {
                Price = 180,
                Imagen = "Assets/Page4/m7.png",
            },
            new ShopItem()
            {
                Price = 190,
                Imagen = "Assets/Page4/m8.png",
            },
            new ShopItem()
            {
                Price = 200,
                Imagen = "Assets/Page4/m1.png",
            }
        };

        public static IList<ShopItem> GetAllMotorItems()
        {
            return MotorShopItems;
        }

        //-----------------------------------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------> BODYWORK SHOP ITEMS <------
        //-----------------------------------------------------------------------------------------------------------------
        public static List<ShopItem> BodyWorkShopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Price = 120,
                Imagen = "Assets/Page4/b1.png",
            },
            new ShopItem()
            {
                Price = 130,
                Imagen = "Assets/Page4/b2.png",
            },
            new ShopItem()
            {
                Price = 140,
                Imagen = "Assets/Page4/b3.png",
            },
            new ShopItem()
            {
                Price = 150,
                Imagen = "Assets/Page4/b4.png",
            },
            new ShopItem()
            {
                Price = 160,
                Imagen = "Assets/Page4/b5.png",
            }
        };

        public static IList<ShopItem> GetAllBodyWorkItems()
        {
            return BodyWorkShopItems;
        }

        //-----------------------------------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------> WHEEL SHOP ITEMS <---------
        //-----------------------------------------------------------------------------------------------------------------
        public static List<ShopItem> WheelShopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Price = 120,
                Imagen = "Assets/Page4/r1.png",
            },
            new ShopItem()
            {
                Price = 130,
                Imagen = "Assets/Page4/r2.png",
            },
            new ShopItem()
            {
                Price = 140,
                Imagen = "Assets/Page4/r3.png",
            },
            new ShopItem()
            {
                Price = 150,
                Imagen = "Assets/Page4/r4.png",
            },
            new ShopItem()
            {
                Price = 160,
                Imagen = "Assets/Page4/r5.png",
            },
            new ShopItem()
            {
                Price = 170,
                Imagen = "Assets/Page4/r2.png",
            },
            new ShopItem()
            {
                Price = 180,
                Imagen = "Assets/Page4/r3.png",
            },
            new ShopItem()
            {
                Price = 190,
                Imagen = "Assets/Page4/r4.png",
            },
            new ShopItem()
            {
                Price = 200,
                Imagen = "Assets/Page4/r5.png",
            }
        };
        public static IList<ShopItem> GetAllWheelItems()
        {
            return WheelShopItems;
        }

        //-----------------------------------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------> COLOR SHOP ITEMS <---------
        //-----------------------------------------------------------------------------------------------------------------
        public static List<ShopItem> ColorShopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Price = 120,
                Imagen = "Assets/Page4/c1.png",
                Type = 0
            },
            new ShopItem()
            {
                Price = 130,
                Imagen = "Assets/Page4/c2.png",
                Type = 1
            },
            new ShopItem()
            {
                Price = 140,
                Imagen = "Assets/Page4/c3.png",
                Type = 2
            },
            new ShopItem()
            {
                Price = 150,
                Imagen = "Assets/Page4/c4.png",
                Type = 3
            },
            new ShopItem()
            {
                Price = 160,
                Imagen = "Assets/Page4/c5.png",
                Type = 4
            },
            new ShopItem()
            {
                Price = 170,
                Imagen = "Assets/Page4/c6.png",
                Type = 5
            },
            new ShopItem()
            {
                Price = 180,
                Imagen = "Assets/Page4/c7.png",
                Type = 6
            },
            new ShopItem()
            {
                Price = 190,
                Imagen = "Assets/Page4/c8.png",
                Type = 7
            },
            new ShopItem()
            {
                Price = 200,
                Imagen = "Assets/Page4/c9.png",
                Type = 8
            }
        };

        public static IList<ShopItem> GetAllColorItems()
        {
            return ColorShopItems;
        }

        //-----------------------------------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------> LIGHT SHOP ITEMS <---------
        //-----------------------------------------------------------------------------------------------------------------
        public static List<ShopItem> LightShopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Price = 120,
                Imagen = "Assets/Page4/f1.png",
            },
            new ShopItem()
            {
                Price = 130,
                Imagen = "Assets/Page4/f2.png",
            },
            new ShopItem()
            {
                Price = 140,
                Imagen = "Assets/Page4/f6.png",
            },
            new ShopItem()
            {
                Price = 150,
                Imagen = "Assets/Page4/f4.png",
            },
            new ShopItem()
            {
                Price = 160,
                Imagen = "Assets/Page4/f5.png",
            },
            new ShopItem()
            {
                Price = 170,
                Imagen = "Assets/Page4/f6.png",
            },
            new ShopItem()
            {
                Price = 180,
                Imagen = "Assets/Page4/f1.png",
            },
            new ShopItem()
            {
                Price = 190,
                Imagen = "Assets/Page4/f2.png",
            },
            new ShopItem()
            {
                Price = 200,
                Imagen = "Assets/Page4/f5.png",
            }
        };

        public static IList<ShopItem> GetAllLightItems()
        {
            return LightShopItems;
        }
    }   
}
