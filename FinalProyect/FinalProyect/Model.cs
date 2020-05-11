using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

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

    public class Model
    {
        public static List<Mision> Misiones = new List<Mision>()
            {
                new Mision()
                {
                    TextoDeMision = "Esquiva a 20 policías",
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
                    TextoDeMision = "Juega 5 partidas con amigos",
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
                    TextoDeMision = "Cambia de coche 3 veces",
                    Objetivo = 5,
                    Progreso = 4,
                },
                new Mision()
                {
                    TextoDeMision = "Participa en 5 eventos",
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
                    TextoDeMision = "Consigue que tu bando gane",
                    Objetivo = 1,
                    Progreso = 0,
                },
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
}
