using NUnit.Framework;
using Pocketbook;


namespace Pocketbook.Tests
{
    [TestFixture]
    public class MeetingTests
    {
        [Test]
        public void MeetingConstructorTest()
        {
            var meeting = CreateNewMeetingReminder();

            Assert.That(meeting.Location, Is.EqualTo("Морская база, Аттитуд"));
            Assert.That(meeting.MeetingPerson, Is.EqualTo("Коллега Михаил"));
            Assert.That(meeting.Topic, Is.EqualTo("Работа"));
        }

        [Test]
        public void MeetingConstructorSetsPropertiesCorrectly()
        {
            var date = new DateTime(2024, 12, 15);
            var time = new TimeSpan(14, 30, 0);
            var location = "Морская база, Аттитуд";
            var meetingPerson = "Коллега Михаил";
            var topic = "Обсуждение дальнейшей работы";

            var meeting = new Meeting(date, time, location, meetingPerson, topic);

            Assert.That(meeting.Location, Is.EqualTo(location));
            Assert.That(meeting.MeetingPerson, Is.EqualTo(meetingPerson));
            Assert.That(meeting.Topic, Is.EqualTo(topic));
        }

        [Test]
        public void MeetingReminderOutputsTest()
        {
            var meeting = new Meeting(
                new DateTime(2024, 12, 15),
                new TimeSpan(14, 30, 0),
                "Морская база, Аттитуд",
                "Коллега Михаил",
                "Обсуждение дальнейшей работы"
            );

            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            meeting.Reminder();
            var output = stringWriter.ToString().Trim();

            Assert.That(output, Does.Contain("Встреча"));
            Assert.That(output, Does.Contain("15.12.2024 в 14:30"));
            Assert.That(output, Does.Contain("Место: Морская база, Аттитуд"));
            Assert.That(output, Does.Contain("С кем: Коллега Михаил"));
            Assert.That(output, Does.Contain("Тема: Обсуждение дальнейшей работы"));
        }

        private Meeting CreateNewMeetingReminder()
        {
            var meeting = new Meeting(
                new DateTime(2024, 12, 15),
                new TimeSpan(14, 30, 0),
                "Морская база, Аттитуд",
                "Коллега Михаил",
                "Работа"
            );
            return meeting;
        }
    }
}
