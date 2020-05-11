using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinalProyect
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page3 : Page
    {
        double font = 48;
        TextBlock[] headerArray;
        TextBlock[] planeTextArray;
        object[] controlArray;
        public Page3()
        {
            this.InitializeComponent();
            headerArray = new TextBlock[3];
            planeTextArray = new TextBlock[7];
            controlArray = new object[7];
            headerArray.SetValue(SonidoText,0);
            headerArray.SetValue(GraficosText,1);
            headerArray.SetValue(ControlesText,2);

            for(int i = 0; i < planeTextArray.Length; i++)
            {

                TextBlock txt = this.FindName("text"+i) as TextBlock;
                object control = this.FindName("control"+i);
                planeTextArray.SetValue(txt,i);
                controlArray.SetValue(control,i);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void gridSizeChanged(object sender, SizeChangedEventArgs e)
        {
            botonSalir.Width = botonSalir.Height = ((Frame)Window.Current.Content).ActualWidth * 0.05;
            botonSalir.Height = botonSalir.Width * 0.8;

            font = ((Frame)Window.Current.Content).ActualWidth/30;
            foreach (TextBlock headerText in headerArray)
            {
                headerText.FontSize = font;
            }
            foreach (TextBlock planeText in planeTextArray)
            {
                planeText.FontSize = font-12;
            }
            foreach (object control in controlArray)
            {
                if(control as Slider != null)
                {
                    Slider s = control as Slider;
                    s.Width = (((Frame)Window.Current.Content).ActualWidth * 0.2);
                }
                else if(control as ComboBox != null)
                {
                    ComboBox c = control as ComboBox;
                    c.Height = font;
                    c.FontSize = font - 17;
                }
                else
                {
                    ToggleSwitch t = control as ToggleSwitch;
                    t.FontSize = font - 12;
                }
            }
        }
    }
}
