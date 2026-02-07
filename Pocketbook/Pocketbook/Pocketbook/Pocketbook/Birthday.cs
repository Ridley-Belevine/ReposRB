using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocketbook
{
    public class Birthday : Event
    {
        public string BirthdayPerson { get; set; }
        public int BirthYear { get; set; }
        public int Age => DateTime.Now.Year - BirthYear;

        public Birthday(DateTime date, TimeSpan time, string location, string birthdayPerson, int birthYear)

            : base(date, time, location)
        {
            BirthdayPerson = birthdayPerson;
            BirthYear = birthYear;
        }

        public override void Reminder()
        {
            Console.WriteLine("День Рождения");

            base.Reminder();

            Console.WriteLine($"Именинник: {BirthdayPerson}");
            Console.WriteLine($"Год рождения: {BirthYear}");
            Console.WriteLine($"Исполняется {Age} лет");
        }
    }
}
