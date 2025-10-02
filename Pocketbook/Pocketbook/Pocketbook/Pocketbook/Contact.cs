using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocketbook
{
    public class Event
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Location { get; set; }

        public Event(DateTime date, TimeSpan time, string location)
        {
            Date = date;
            Time = time;
            Location = location;
        }

        public virtual void Reminder()
        {
            Console.WriteLine($"Событие: {Date:dd.MM.yyyy} в {Time:hh\\:mm}");
            Console.WriteLine($"Место: {Location}");
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public string Address { get; set; }
        public ulong PhoneNumber { get; set; }
        public readonly long Identifier;
        public string Notes { get; set; }

        public Contact(string name, string surname, string group, string address, ulong phoneNumber, long identifier, string notes)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Address = address;
            PhoneNumber = phoneNumber;
            Identifier = identifier;
            Notes = notes;
        }

        private static readonly Dictionary<string, string> GroupNames = new Dictionary<string, string>
        {
            { "Family", "Семья" },
            { "Friends", "Друзья" },
            { "Pals", "Знакомые" },
            { "Colleagues", "Работа" },
            { "NoGroup", "Без группы" }
        };

        public string[] GetInfo()
        {
            string groupDisplayName = GroupNames.ContainsKey(Group) ? GroupNames[Group] : Group;

            var info = new string[4];
            info[0] = $"{Name} {Surname}, {groupDisplayName}";
            info[1] = $"{Address}, {PhoneNumber}";
            info[2] = $"{Identifier}";
            info[3] = $"{Notes}";

            return info;
        }
    }
}
