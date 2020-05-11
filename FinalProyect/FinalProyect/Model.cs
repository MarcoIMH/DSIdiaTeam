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
