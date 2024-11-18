using Messenger_TEB_MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger_TEB_MAUI.Services
{
    public class DataServices
    {
        public static List<Person> LoadPersons(string filePath)
        {
            var persons = new List<Person>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (line.StartsWith("Id"))
                {
                    var parts = line.Split(',');
                    var person = new Person
                    {
                        Id = int.Parse(parts[0].Split('=')[1].Trim()),
                        Name = parts[1].Split('=')[1].Trim().Trim('"'),
                        Description = parts[2].Split('=')[1].Trim().Trim('"'),
                        ImageLink = parts[3].Split('=')[1].Trim().Trim('"')
                    };
                    persons.Add(person);
                }
            }

            return persons;
        }
    }
}
