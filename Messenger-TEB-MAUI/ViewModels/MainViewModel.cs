using Messenger_TEB_MAUI.Models;
using Messenger_TEB_MAUI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger_TEB_MAUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _chatItems;
        public ObservableCollection<Person> ChatItems
        {
            get => _chatItems;
            set
            {
                _chatItems = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChatItems)));
            }
        }

        private Person _selectedChat;
        public Person SelectedChat
        {
            get => _selectedChat;
            set
            {
                _selectedChat = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedChat)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainViewModel()
        {
            var filePath = @"C:\Users\admin\source\repos\Messenger-TEB-MAUI\Messenger-TEB-MAUI\Data\dane2.txt";
            ChatItems = new ObservableCollection<Person>();

            // Przykładowe dane
            ChatItems.Add(new Person
            {
                Id = 1,
                Name = "Jan Postulski",
                Description = "Kawa to moje życie",
                ImageLink = "osoba1.jpg",
                Messages = new ObservableCollection<Message>
                    {
                        new Message { Sender = "Jan Postulski", Text = "Siema, gdzie jesteś? Czekam na Ciebie pod Twoim blokiem.", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Poczekaj chwilę, jeszcze muszę skończyć projekt, który mam do oddania.", IsSentByUser = true },
                        new Message { Sender = "Jan Postulski", Text = "Długo Ci to zajmie?", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Jeszcze tak z 15 minut.", IsSentByUser = true },
                        new Message { Sender = "Jan Postulski", Text = "Dobra, tylko byleby nie dłużej!", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Dobra dobra...", IsSentByUser = true }
                    }
            });

            ChatItems.Add(new Person
            {
                Id = 2,
                Name = "Alicja Bystra",
                Description = "<brak opisu>",
                ImageLink = "osoba2.jpg",
                Messages = new ObservableCollection<Message>
                    {
                        new Message { Sender = "Alicja Bystra", Text = "Hej, co tam?", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Cześć, wszystko w porządku. A u Ciebie?", IsSentByUser = true },
                        new Message { Sender = "Alicja Bystra", Text = "U mnie też dobrze, dzięki.", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Super, co planujesz na weekend?", IsSentByUser = true }
                    }
            });

            ChatItems.Add(new Person
            {
                Id = 3,
                Name = "Adrianna Nowak",
                Description = "Przyroda to ciężki przedmiot",
                ImageLink = "osoba3.jpg",
                Messages = new ObservableCollection<Message>
                    {
                        new Message { Sender = "Adrianna Nowak", Text = "Masz notatki z przyrody?", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Tak, mogę Ci je przesłać.", IsSentByUser = true },
                        new Message { Sender = "Adrianna Nowak", Text = "Dzięki, bardzo mi pomogłeś.", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Nie ma sprawy, zawsze do usług.", IsSentByUser = true }
                    }
            });

            ChatItems.Add(new Person
            {
                Id = 4,
                Name = "Grażyna Łuk",
                Description = "Życie mnie mnie",
                ImageLink = "osoba4.jpg",
                Messages = new ObservableCollection<Message>
                    {
                        new Message { Sender = "Grażyna Łuk", Text = "Co robisz w weekend?", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Jeszcze nie wiem, a Ty?", IsSentByUser = true },
                        new Message { Sender = "Grażyna Łuk", Text = "Myślę o wyjeździe za miasto.", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Brzmi świetnie, może się dołączę.", IsSentByUser = true }
                    }
            });

            ChatItems.Add(new Person
            {
                Id = 5,
                Name = "Krystian Błąd",
                Description = "Life is fun",
                ImageLink = "osoba5.jpg",
                Messages = new ObservableCollection<Message>
                    {
                        new Message { Sender = "Krystian Błąd", Text = "Idziemy na imprezę?", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Jasne, kiedy?", IsSentByUser = true },
                        new Message { Sender = "Krystian Błąd", Text = "W sobotę wieczorem.", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Pasuje, do zobaczenia!", IsSentByUser = true }
                    }
            });

            ChatItems.Add(new Person
            {
                Id = 6,
                Name = "Adrian Jańczyk",
                Description = "Droga do sukcesu nie jest prosta",
                ImageLink = "osoba6.jpg",
                Messages = new ObservableCollection<Message>
                    {
                        new Message { Sender = "Adrian Jańczyk", Text = "Masz czas na spotkanie?", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Tak, kiedy Ci pasuje?", IsSentByUser = true },
                        new Message { Sender = "Adrian Jańczyk", Text = "Może jutro po południu?", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Ok, pasuje mi.", IsSentByUser = true }
                    }
            });

            ChatItems.Add(new Person
            {
                Id = 7,
                Name = "Michaś Kowalczyk",
                Description = "Gry to moja specjalność",
                ImageLink = "osoba7.jpg",
                Messages = new ObservableCollection<Message>
                    {
                        new Message { Sender = "Michaś Kowalczyk", Text = "Gramy dzisiaj wieczorem?", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Tak, o której?", IsSentByUser = true },
                        new Message { Sender = "Michaś Kowalczyk", Text = "O 20:00.", IsSentByUser = false },
                        new Message { Sender = "Ty", Text = "Pasuje, do zobaczenia online!", IsSentByUser = true }
                    }
            });

            // Ustawienie domyślnego czatu na "Jan Postulski"
            SelectedChat = ChatItems.FirstOrDefault(c => c.Name == "Jan Postulski");
        }
    }
}
