using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinalProyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class start_game : Page
    {
        public ObservableCollection<Amigo> ListaAmigosConec { get; } = new ObservableCollection<Amigo>();
        public ObservableCollection<Amigo> ListaAmigosDesconec { get; } = new ObservableCollection<Amigo>();
        public ObservableCollection<Chat> ListatChatGeneral { get; } = new ObservableCollection<Chat>();
        public ObservableCollection<Chat> ListatChatAmigos { get; } = new ObservableCollection<Chat>();

        public start_game()
        {
            this.InitializeComponent();
            if (ListaAmigosConec != null)
            {
                foreach (Amigo m in AmigoModel.GetAllAmigos())
                {
                    ListaAmigosConec.Add(m);
                }
            }
            if (ListaAmigosDesconec != null)
            {
                foreach (Amigo m in AmigoModel.GetAllAmigosDesc())
                {
                    ListaAmigosDesconec.Add(m);
                }
            }
            if (ListatChatGeneral != null)
            {
                foreach (Chat m in ChatModel.GetChatGeneral())
                {
                    ListatChatGeneral.Add(m);
                }
            }
            if (ListatChatAmigos != null)
            {
                foreach (Chat m in ChatModel.GetChatAmigos())
                {
                    ListatChatAmigos.Add(m);
                }
            }
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            exit.Width = grid_.ColumnDefinitions.ElementAt(0).ActualWidth * 2 / 3;
            exit.Height = grid_.RowDefinitions.ElementAt(0).ActualHeight;

            user1.Width = user1.Height = grid_.RowDefinitions.ElementAt(1).ActualHeight;
            user2.Width = user2.Height = grid_.RowDefinitions.ElementAt(1).ActualHeight;
            user3.Width = user3.Height = grid_.RowDefinitions.ElementAt(1).ActualHeight;
            user4.Width = user4.Height = grid_.RowDefinitions.ElementAt(1).ActualHeight;

            chat_general.MaxHeight = grid_.RowDefinitions.ElementAt(3).ActualHeight * 2 / 3;
            chat_amigos.MaxHeight = grid_.RowDefinitions.ElementAt(3).ActualHeight * 2 / 3;
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page6));
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((user1.Source as BitmapImage).UriSource.ToString() == "ms-appx:///Assets/user.png")
                user1.Source = ((sender as Button).Content as Image).Source;
            else if ((user2.Source as BitmapImage).UriSource.ToString() == "ms-appx:///Assets/user.png")
                user2.Source = ((sender as Button).Content as Image).Source;
            else if ((user3.Source as BitmapImage).UriSource.ToString() == "ms-appx:///Assets/user.png")
                user3.Source = ((sender as Button).Content as Image).Source;
            else if ((user4.Source as BitmapImage).UriSource.ToString() == "ms-appx:///Assets/user.png")
                user4.Source = ((sender as Button).Content as Image).Source;

            (sender as Button).Visibility = Visibility.Collapsed;

            StackPanel h = (e.OriginalSource as Button).Parent as StackPanel;
            h.Visibility = Visibility.Collapsed;
            StackPanel s = h.Parent as StackPanel;
            (s.Children.ElementAt(2) as TextBlock).Text = "in group";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            chat_general.Visibility = Visibility.Visible;
            chat_amigos.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            chat_general.Visibility = Visibility.Collapsed;
            chat_amigos.Visibility = Visibility.Visible;
        }

        private void TextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                if (chat_general.Visibility == Visibility.Visible)
                {
                    ListatChatGeneral.Add(new Chat("You", "You : " + (e.OriginalSource as TextBox).Text));
                    chat_general.ScrollIntoView(chat_general.Items.Last());
                    (e.OriginalSource as TextBox).Text = "";
                }
                   
                else if (chat_amigos.Visibility == Visibility.Visible)
                {
                    ListatChatAmigos.Add(new Chat("You", "You : " + (e.OriginalSource as TextBox).Text));
                    chat_amigos.ScrollIntoView(chat_amigos.Items.Last());
                    (e.OriginalSource as TextBox).Text = "";
                }
            }
        }
    }
}
