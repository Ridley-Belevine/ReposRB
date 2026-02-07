using NUnit.Framework;
using Pocketbook;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pocketbook.Tests
{
    [TestFixture]
    public class BirthdayTests
    {
        [Test]
        public void BirthdayConstructorTest()
        {
            var birthday = CreateNewBirthdayReminder();

            Assert.That(birthday.Location, Is.EqualTo("Дом"));
            Assert.That(birthday.BirthdayPerson, Is.EqualTo("Джейн Доу"));
            Assert.That(birthday.BirthYear, Is.EqualTo(1964));
        }

        [Test]
        public void BirthdayConstructorSetsPropertiesCorrectly()
        {
            var date = new DateTime(2024, 12, 15);
            var time = new TimeSpan(18, 0, 0);
            var location = "Дом";
            var birthdayPerson = "Джейн Доу";
            var birthYear = 1964;

            var birthday = new Birthday(date, time, location, birthdayPerson, birthYear);

            Assert.That(birthday.Date, Is.EqualTo(date));
            Assert.That(birthday.Time, Is.EqualTo(time));
            Assert.That(birthday.Location, Is.EqualTo(location));
            Assert.That(birthday.BirthdayPerson, Is.EqualTo(birthdayPerson));
            Assert.That(birthday.BirthYear, Is.EqualTo(birthYear));
        }

        [Test]
        public void BirthdayAgeCalculatesCorrectly()
        {
            var currentYear = DateTime.Now.Year;
            var birthYear = 1964;
            var expectedAge = currentYear - birthYear;

            var birthday = new Birthday(
                new DateTime(2024, 12, 15),
                new TimeSpan(18, 0, 0),
                "Дом",
                "Джейн Доу",
                birthYear
            );

            Assert.That(birthday.Age, Is.EqualTo(expectedAge));
        }

        private Birthday CreateNewBirthdayReminder()
        {
            var birthday = new Birthday(
            new DateTime(2024, 12, 15),
            new TimeSpan(18, 0, 0),
            "Дом",
            "Джейн Доу",
            1964
            );
            return birthday;
        }

        [Test]
        public void BirthdayReminderOutputsTest()
        {
            var birthday = new Birthday(
            new DateTime(2024, 12, 15),
            new TimeSpan(18, 0, 0),
            "Дом",
            "Джейн Доу",
            1964
            );

            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            birthday.Reminder();
            var output = stringWriter.ToString().Trim();

            Assert.That(output, Does.Contain("День Рождения"));
            Assert.That(output, Does.Contain("15.12.2024 в 18:00"));
            Assert.That(output, Does.Contain("Место: Дом"));
            Assert.That(output, Does.Contain("Именинник: Джейн Доу"));
            Assert.That(output, Does.Contain("Год рождения: 1964"));
            Assert.That(output, Does.Contain($"Исполняется {birthday.Age} лет"));
        }
    }
}
