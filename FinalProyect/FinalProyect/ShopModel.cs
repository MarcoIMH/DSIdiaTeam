using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FinalProyect
{
    public class ShopItem
    {
        public int Price { get; set; }
        public string Imagen {get;set;}

        public ShopItem() { }
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
                Imagen = "Assets/Page4/motorIcon.png",  
            },
            new ShopItem()
            {
                Price = 130,
                Imagen = "Assets/Page4/motorIcon.png",
            },
            new ShopItem()
            {
                Price = 140,
                Imagen = "Assets/Page4/motorIcon.png",
            },
            new ShopItem()
            {
                Price = 150,
                Imagen = "Assets/Page4/motorIcon.png",
            },
            new ShopItem()
            {
                Price = 160,
                Imagen = "Assets/Page4/motorIcon.png",
            },
            new ShopItem()
            {
                Price = 170,
                Imagen = "Assets/Page4/motorIcon.png",
            },
            new ShopItem()
            {
                Price = 180,
                Imagen = "Assets/Page4/motorIcon.png",
            },
            new ShopItem()
            {
                Price = 190,
                Imagen = "Assets/Page4/motorIcon.png",
            },
            new ShopItem()
            {
                Price = 200,
                Imagen = "Assets/Page4/motorIcon.png",
            }
        };

        public static IList<ShopItem> GetAllMotorItems()
        {
            return MotorShopItems;
        }

        //-----------------------------------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------> WHEEL SHOP ITEMS <---------
        //-----------------------------------------------------------------------------------------------------------------
        public static List<ShopItem> WheelShopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Price = 120,
                Imagen = "Assets/Page4/wheelIcon.png",
            },
            new ShopItem()
            {
                Price = 130,
                Imagen = "Assets/Page4/wheelIcon.png",
            },
            new ShopItem()
            {
                Price = 140,
                Imagen = "Assets/Page4/wheelIcon.png",
            },
            new ShopItem()
            {
                Price = 150,
                Imagen = "Assets/Page4/wheelIcon.png",
            },
            new ShopItem()
            {
                Price = 160,
                Imagen = "Assets/Page4/wheelIcon.png",
            },
            new ShopItem()
            {
                Price = 170,
                Imagen = "Assets/Page4/wheelIcon.png",
            },
            new ShopItem()
            {
                Price = 180,
                Imagen = "Assets/Page4/wheelIcon.png",
            },
            new ShopItem()
            {
                Price = 190,
                Imagen = "Assets/Page4/wheelIcon.png",
            },
            new ShopItem()
            {
                Price = 200,
                Imagen = "Assets/Page4/wheelIcon.png",
            }
        };

        public static IList<ShopItem> GetAllWheelItems()
        {
            return WheelShopItems;
        }
    }   
}
