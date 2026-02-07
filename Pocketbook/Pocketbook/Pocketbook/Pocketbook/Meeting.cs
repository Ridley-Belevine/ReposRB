using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocketbook
{
    public class Meeting : Event
    {
        public string MeetingPerson { get; set; }
        public string Topic { get; set; }

        public Meeting(DateTime date, TimeSpan time, string location, string meetingPerson, string topic)

            : base(date, time, location)
        {
            MeetingPerson = meetingPerson;
            Topic = topic;
        }
        public override void Reminder()
        {
            Console.WriteLine("Встреча");

            base.Reminder();

            Console.WriteLine($"С кем: {MeetingPerson}");
            Console.WriteLine($"Тема: {Topic}");
        }
    }
}
