using Messenger_TEB_MAUI.Models;
using Messenger_TEB_MAUI.ViewModels;

namespace Messenger_TEB_MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void OnChatSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var selectedChat = e.CurrentSelection[0] as Person;
                if (selectedChat != null)
                {
                    // Ustaw nowy kontekst danych dla widoku rozmowy
                    ChatView.BindingContext = selectedChat;
                }
            }
        }

        private void OnImageTapped(object sender, EventArgs e)
        {
            var image = sender as Image;
            var selectedChat = image?.BindingContext as Person;
            if (selectedChat != null)
            {
                // Ustaw nowy kontekst danych dla widoku rozmowy
                ChatView.BindingContext = selectedChat;
            }
        }
    }

}
