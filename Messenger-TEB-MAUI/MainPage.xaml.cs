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
    }

}
