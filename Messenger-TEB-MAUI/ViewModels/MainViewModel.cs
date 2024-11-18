using Messenger_TEB_MAUI.Models;
using Messenger_TEB_MAUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger_TEB_MAUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;


        private List<Person> _chatItems;
        public List<Person> ChatItems
        {
            get => _chatItems;
            set
            {
                _chatItems = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChatItems)));
            }
        }

        public MainViewModel()
        {
            var filePath = @"C:\Users\admin\source\repos\Messenger-TEB-MAUI\Messenger-TEB-MAUI\Data\dane.txt";
            ChatItems = DataServices.LoadPersons(filePath);
        }
    }
}
