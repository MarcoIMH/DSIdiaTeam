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
    public enum tipoEvento
    {
        roboBanco, huida, rescate
    }
    public enum mapa
    {
        fuencacity, berlin, chicago
    }
    public enum bando
    {
        policia, ladrones
    }

    public class Jugador
    {
        public string Nombre { get; set; }
        public string Bando { get; set; }
        public int PartidasJugadas { get; set; }
        public int PartidasGanadas { get; set; }

        public Jugador(string nombre, bando band, int partidasJugadas, int partidasGanadas)
        {
            Nombre = nombre;
            if (band == bando.policia) Bando = "Policía";
            else Bando = "Ladrones";
            PartidasJugadas = partidasJugadas;
            PartidasGanadas = partidasGanadas;
        }
    }


    public class Mision
    {
        public string Imagen { get; set; }
        public string TextoDeMision { get; set; }
        public int Objetivo { get; set; }
        public int Progreso { get; set; }

        public Mision()
        {
            Imagen = "ms-appx:///Assets/Imagenes/misionIcon.png";
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
                    TextoDeMision = "Evita a 20 policías",
                    Objetivo = 5,
                    Progreso = 1,
                },
                new Mision()
                {
                    TextoDeMision = "Gana 5 partidas",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Escapa 5 veces",
                    Objetivo = 5,
                    Progreso = 4,
                },
                new Mision()
                {
                    TextoDeMision = "Consigue 1000$",
                    Objetivo = 5,
                    Progreso = 2,
                },
                new Mision()
                {
                    TextoDeMision = "Juega 5 partidas",
                    Objetivo = 5,
                    Progreso = 2,
                },
                new Mision()
                {
                    TextoDeMision = "Usa 20 power ups",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Compra 5 piezas",
                    Objetivo = 5,
                    Progreso = 1,
                },
                new Mision()
                {
                    TextoDeMision = "Usa 3 coches",
                    Objetivo = 5,
                    Progreso = 4,
                },
                new Mision()
                {
                    TextoDeMision = "Juega 5 eventos",
                    Objetivo = 5,
                    Progreso = 2,
                },
                new Mision()
                {
                    TextoDeMision = "Gana 3 eventos",
                    Objetivo = 5,
                    Progreso = 3,
                },
                new Mision()
                {
                    TextoDeMision = "Victoria de bando",
                    Objetivo = 1,
                    Progreso = 0,
                },
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

    public class Evento
    {
        public string Imagen { get; set; }
        public string Fecha { get; set; }
        public string Tipo { get; set; }
        public string Mapa { get; set; }

        public Evento(tipoEvento tipo, mapa map)
        {
            Imagen = "ms-appx:///Assets/Imagenes/eventoIcon.png";

            switch (tipo)
            {
                case tipoEvento.roboBanco:
                    Tipo = "Robo a banco";
                    break;
                case tipoEvento.huida:
                    Tipo = "Huida";
                    break;
                case tipoEvento.rescate:
                    Tipo = "Rescate";
                    break;
                default:
                    break;
            }

            switch (map)
            {
                case mapa.fuencacity:
                    Mapa = "Fuencacity";
                    break;
                case mapa.berlin:
                    Mapa = "Berlín";
                    break;
                case mapa.chicago:
                    Mapa = "Chicago";
                    break;
                default:
                    break;
            }
        }

    }

    public class EventModel
    {
        public static List<Evento> Eventos = new List<Evento>()
        {
            new Evento(tipoEvento.roboBanco, mapa.fuencacity)
            {
                Fecha = "24/05/2020"
            },

            new Evento(tipoEvento.roboBanco, mapa.berlin)
            {
                Fecha = "25/05/2020"
            },

            new Evento(tipoEvento.roboBanco, mapa.chicago)
            {
                Fecha = "26/05/2020"
            },

            new Evento(tipoEvento.huida, mapa.chicago)
            {
                Fecha = "27/05/2020"
            },

            new Evento(tipoEvento.rescate, mapa.fuencacity)
            {
                Fecha = "28/05/2020"
            },

            new Evento(tipoEvento.roboBanco, mapa.berlin)
            {
                Fecha = "29/05/2020"
            },

            new Evento(tipoEvento.huida, mapa.berlin)
            {
                Fecha = "30/05/2020"
            },

             new Evento(tipoEvento.roboBanco, mapa.chicago)
            {
                Fecha = "01/06/2020"
            },

              new Evento(tipoEvento.rescate, mapa.chicago)
            {
                Fecha = "02/06/2020"
            },

               new Evento(tipoEvento.huida, mapa.fuencacity)
            {
                Fecha = "02/06/2020"
            },
        };

        public static IList<Evento> GetAllEvents()
        {
            return Eventos;
        }

        public static Evento GetEventById(int id)
        {
            return Eventos[id];
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
