using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
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
        public Visibility active { get; set; }

        public Amigo()
        {
            addImageSource = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/+.png"));
        }
    }

    public class AmigoModel
    {
        public static List<Amigo> AmigosConectados = new List<Amigo>()
        {
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/5.jpg",
                contectedState = "Online",
                color = "#ff22dd55",
                name = "Pepe"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/6.jpg",
                contectedState = "Online",
                color = "#ff22dd55",
                name = "Jorge"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/7.jpg",
                contectedState = "Online",
                color = "#ff22dd55",
                name = "Aitor"
            },
        };

        public static List<Amigo> AmigosDesconectados = new List<Amigo>()
        {
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/5.jpg",
                contectedState = "offline",
                color = "#ffdd2255",
                name = "Lola"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/6.jpg",
                contectedState = "offline",
                color = "#ffdd2255",
                name = "Ana"
            },
            new Amigo()
            {
                profileImageSource = "Assets/Imagenes/7.jpg",
                contectedState = "offline",
                color = "#ffdd2255",
                name = "Rodrigo"
            },
        };

        public static IList<Amigo> GetAllAmigos()
        {
            return AmigosConectados;
        }

        public static IList<Amigo> GetAllAmigosDesc()
        {
            return AmigosDesconectados;
        }
    }
    public class Chat
    {
        public string name { get; set; }
        public string text { get; set; }

        public Chat()
        {
        }
        public Chat(string Name, string Text)
        {
            name = Name;
            text = Text;
        }
    }

    public class ChatModel
    {
        public static List<Chat> ChatGeneral = new List<Chat>()
        {
            new Chat()
            {
                name = "Pepe",
                text = "Pepe: Hello there"
            },
            new Chat()
            {
                name = "Pepe",
                text = "Pepe: ?????",
            },
            new Chat()
            {
                name = "Pepe",
                text = "Pepe: Hello there"
            },
            new Chat()
            {
                name = "Pepe",
                text = "Pepe: Hello there"
            },
            new Chat()
            {
                name = "Roberto",
                text = "Roberto: spammer"
            },
            new Chat()
            {
                name = "Pepe",
                text = "Pepe: dude, no one was answering back..."
            }
        };

        public static List<Chat> ChatAmigos = new List<Chat>()
        {
            new Chat()
            {
                name = "Jorge",
                text = "Jorge: inviten inviten :)"
            },
            new Chat()
            {
                name = "Aitor",
                text = "Aitor: Venga bro invita",
            },
            new Chat()
            {
                name = "You",
                text = "You: un momento"
            },
        };

        public static IList<Chat> GetChatGeneral()
        {
            return ChatGeneral;
        }

        public static IList<Chat> GetChatAmigos()
        {
            return ChatAmigos;
        }
    }
}
