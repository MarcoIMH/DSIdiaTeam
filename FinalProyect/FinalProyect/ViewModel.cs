using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace FinalProyect
{
    public class VMMision : Mision
    {
        public VMMision(Mision mision)
            {
            TextoDeMision = mision.TextoDeMision;
            Objetivo = mision.Objetivo;
            Progreso = mision.Progreso;

            //Img = new Image();
            //string s = System.IO.Directory.GetCurrentDirectory() + "\\" + mision.Imagen;
            //Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            //Img.Width = 50;
            //Img.Height = 50;

            //CCImg.Visibility = Windows.UI.Xaml.Visibility.Visible;//.Collapsed;
            //Mapa.Children.Add(CCImg);
            //Mapa.Children.Last().SetValue(Canvas.LeftProperty, X - 25);
            //Mapa.Children.Last().SetValue(Canvas.TopProperty, Y - 25);
        }
    }


   
}
