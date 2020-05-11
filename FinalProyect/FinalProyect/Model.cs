using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace FinalProyect
{
    public class Mision
    {
        public string Imagen { get; set; }
        //public Image Imagen { get; set; }
        public string TextoDeMision { get; set; }
        public int Objetivo { get; set; }
        public int Progreso { get; set; }

        public Mision()
        {
            Imagen = "ms-appx:///Assets/Imagenes/misinIcon.png";
            //Imagen = new Image();
            //string s = "ms - appx:///Assets/Imagenes/Botones/botonSalir.png";
            ////string s = System.IO.Directory.GetCurrentDirectory() + "\\" + mision.Imagen;
            //Imagen.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            //Imagen.Width = 50;
            //Imagen.Height = 50; }
        }
        public class Model
        {
            public static List<Mision> Misiones = new List<Mision>()
            {
                new Mision()
                {
                    TextoDeMision = "Texto de mision 1",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 2",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 3",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 4",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 5",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 6",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 7",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 8",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 9",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 10",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 11",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 12",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 13",
                    Objetivo = 5,
                    Progreso = 3,
                }
            };

            public static IList<Mision> GetAllMisions()
            {
                return Misiones;
            }

            public static Mision GetMisionById(int id)
            {
                return Misiones[id];
            }

        }
    }

    public class Amigo
    {
        public string profileImageSource { get; set; }
        public ImageSource addImageSource { get; set; }
        public string contectedState { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public string active { get; set; }

        public Amigo()
        {
            addImageSource = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/+.png"));
        }
    }

    public class AmigoModel
    {
        public static List<Amigo> Amigos = new List<Amigo>()
        {
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/1.jpg",
                active = "Visible",
                contectedState = "online",
                color = "#ff22dd55",
                name = "Ana bogüeles"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/2.jpg",
                active = "Visible",
                contectedState = "online",
                color = "#ff22dd55",
                name = "Tommy Mírabo"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/3.jpg",
                active = "Visible",
                contectedState = "online",
                color = "#ff22dd55",
                name = "Tomás Turbado"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/4.jpg",
                active = "Visible",
                contectedState = "online",
                color = "#ff22dd55",
                name = "Paco Guerte"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/5.jpg",
                active = "Collapsed",
                contectedState = "offline",
                color = "#ffdd2255",
                name = "Memo Hérdes"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/6.jpg",
                active = "Collapsed",
                contectedState = "offline",
                color = "#ffdd2255",
                name = "Pepe Lotaso"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/7.jpg",
                active = "Collapsed",
                contectedState = "offline",
                color = "#ffdd2255",
                name = "Aitor Tilla"
            },
        };

        public static IList<Amigo> GetAllAmigos()
        {
            return Amigos;
        }

        public static Amigo GetAmigoById(int id)
        {
            return Amigos[id];
        }

    }
}
