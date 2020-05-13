using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FinalProyect
{
    public class Mision
    {
        public string Imagen { get; set; }
        public Image Img { get; set; }
        public string TextoDeMision { get; set; }
        public int Objetivo { get; set; }
        public int Progreso { get; set; }

        public Mision()
        {
            Imagen = "ms-appx:///Assets/Imagenes/misionIcon.png";
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
        }
        
    }
    public class Policia
    {
        public string Nombre { get; set; }

        public Policia()
        {
            Nombre = "";
        }

    }
    public class Ladron
    {
        public string Nombre { get; set; }

        public Ladron()
        {
            Nombre = "";
        }

    }

    public class Model
    {
        public static List<Mision> Misiones = new List<Mision>()
            {
                new Mision()
                {
                    TextoDeMision = "Texto de mision 1",
                    Objetivo = 5,
                    Progreso = 1,
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
                    Progreso = 4,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 4",
                    Objetivo = 5,
                    Progreso = 2,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 5",
                    Objetivo = 5,
                    Progreso = 2,
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
                    Progreso = 1,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 8",
                    Objetivo = 5,
                    Progreso = 4,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 9",
                    Objetivo = 5,
                    Progreso = 2,
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
                    Progreso = 2,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 12",
                    Objetivo = 5,
                    Progreso = 4,
                },
                new Mision()
                {
                    TextoDeMision = "Texto de mision 13",
                    Objetivo = 5,
                    Progreso = 1,
                }
            };
        public static List<Policia> Policias = new List<Policia>()
        {
            new Policia()
            {
                Nombre = "Chad"
            },
            new Policia()
            {
                Nombre = "Arwa"
            },
            new Policia()
            {
                Nombre = "Humphrey"
            },
            new Policia()
            {
                Nombre = "Livingston"
            },
            new Policia()
            {
                Nombre = "Zohaib"
            },
            new Policia()
            {
                Nombre = "Yosef"
            },
            new Policia()
            {
                Nombre = "Thornton"
            },
            new Policia()
            {
                Nombre = "Mariya"
            },
            new Policia()
            {
                Nombre = "Eesha"
            },
            new Policia()
            {
                Nombre = "Barnard"
            }
        };
        public static List<Ladron> Ladrones = new List<Ladron>()
        {
            new Ladron()
            {
                Nombre = "Eugene"
            },
            new Ladron()
            {
                Nombre = "Lucas"
            },
            new Ladron()
            {
                Nombre = "Donovan"
            },
            new Ladron()
            {
                Nombre = "Theodor"
            },
            new Ladron()
            {
                Nombre = "Marshall"
            },
            new Ladron()
            {
                Nombre = "Elaine"
            },
            new Ladron()
            {
                Nombre = "Garrison"
            },
            new Ladron()
            {
                Nombre = "Bryan"
            },
            new Ladron()
            {
                Nombre = "Dotson"
            },
            new Ladron()
            {
                Nombre = "Keller"
            }
        };

        public static IList<Mision> GetAllMisions()
        {
            return Misiones;
        }
        public static IList<Policia> GetAllPolices()
        {
            return Policias;
        }
        public static IList<Ladron> GetAllRobbers()
        {
            return Ladrones;
        }

        public static Mision GetMisionById(int id)
        {
            return Misiones[id];
        }

    }
}
