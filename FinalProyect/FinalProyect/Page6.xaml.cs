using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public sealed partial class Page6 : Page
    {
        DispatcherTimer dispatcherTimer;
        DateTimeOffset startTime;
        DateTimeOffset lastTime;
        DateTimeOffset stopTime;
        int timesTicked = 1;
        int timesToTick = 100;
        public Page6()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(start_game));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimerSetup();
        }
        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 25);
            //IsEnabled defaults to false

            startTime = DateTimeOffset.Now;
            lastTime = startTime;

            dispatcherTimer.Start();
            //IsEnabled should now be true after calling start

        }

        void dispatcherTimer_Tick(object sender, object e)
        {
            DateTimeOffset time = DateTimeOffset.Now;
            TimeSpan span = time - lastTime;
            lastTime = time;
            //Time since last tick should be very very close to Interval
            LoadingBar.Value += 1;
            timesTicked++;
            if (timesTicked > timesToTick)
            {
                stopTime = time;

                dispatcherTimer.Stop();
                //IsEnabled should now be false after calling stop
                PlayBtn.IsEnabled = true;
                span = stopTime - startTime;

            }
        }

        private void gridSizeChanged(object sender, SizeChangedEventArgs e)
        {
            botonSalir.Width = botonSalir.Height = ((Frame)Window.Current.Content).ActualWidth * 0.05;
            botonSalir.Height = botonSalir.Width * 0.8;

            policeRect.Width = ((Frame)Window.Current.Content).ActualWidth * 0.13;
            policeText.FontSize = (policeRect.Width / 10) + 12;
            policeList.Width = policeRect.Width;
            policeList.Height = ((Frame)Window.Current.Content).ActualHeight * 0.5;

            robberRect.Width = ((Frame)Window.Current.Content).ActualWidth * 0.13;
            robberText.FontSize = (robberRect.Width / 10) + 12;
            robberList.Width = policeRect.Width;
            robberList.Height = policeList.Height;

            Map.Width = ((Frame)Window.Current.Content).ActualWidth * 0.4;
            Map.Height = ((Frame)Window.Current.Content).ActualHeight * 0.4;
            MapName.FontSize = Map.Width / 10 + 12;
            EventName.FontSize = MapName.FontSize - 20;
            PlayBtn.Width = Map.Width * 0.3;
            PlayBtn.Height = ((Frame)Window.Current.Content).ActualHeight * 0.1;
            textoJugar.FontSize = PlayBtn.Width / 4;

            Map.Margin = new Thickness { Top = (MapName.FontSize+20) + (EventName.FontSize+20)};
            EventName.Margin = new Thickness { Top = (MapName.FontSize)};
            PoliceIcon.Margin = new Thickness{Left = policeList.Width + 20};
            RobberIcon.Margin = new Thickness{Right = robberList.Width + 20};
            PlayBtn.Margin = new Thickness { Top = Map.Margin.Top + Map.Height};
            LoadingText.Margin = new Thickness { Bottom = LoadingBar.Height/3 - 15 };

            LoadingBar.Width = ((Frame)Window.Current.Content).ActualWidth * 0.8;
            LoadingText.FontSize = MapName.FontSize;

        }

        private void PlayBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page7));
        }
    }
}
