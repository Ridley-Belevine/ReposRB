using NUnit.Framework;
using Pocketbook;

namespace Pocketbook.Tests
{
    [TestFixture]
    public class ContactUnitTests
    {
        private Contact CreateTestContact()
        {
            return new Contact(
                "Джейн", 
                "Доу", 
                "Работа", 
                "г.Туфорт, Нью-Мексико, США", 
                235020596,
                2,
                "Свадьба с Жанной, вторник, 12:00"
                );
        }

        [Test]
        public void ConstructorTest()
        {
            var contact = CreateTestContact();

            Assert.That(contact.Name, Is.EqualTo("Джейн"));
            Assert.That(contact.Surname, Is.EqualTo("Доу"));
            Assert.That(contact.Group, Is.EqualTo("Работа"));
            Assert.That(contact.Address, Is.EqualTo("г.Туфорт, Нью-Мексико, США"));
            Assert.That(contact.PhoneNumber, Is.EqualTo(235020596UL));
            Assert.That(contact.Identifier, Is.EqualTo(2));
            Assert.That(contact.Notes, Is.EqualTo("Свадьба с Жанной, вторник, 12:00"));
        }

        [Test]
        public void CompareToSortsBySurname()
        {
            var contact1 = new Contact("Джейн", "Доу", "Работа", "г.Туфорт, Нью-Мексико, США", 235020596, 2, "Свадьба с Жанной, вторник, 12:00");
            var contact2 = new Contact("Герберт", "Людвиг", "Работа", "г.Штутгарт, Баден-Вюртемберг, Германия", 680030661, 7, "Встретиться и обсудить аспекты лечения");
            var contact3 = new Contact("Джереми", "Уиллис", "Друзья", "г.Бостон, Нью-Джерси, США", 405000577, 1, "Закупиться к празднованию Рождества, Мега Молл, 17:30");
            var contact4 = new Contact("Жанна", "Доу", "Семья", "г.Туфорт, Нью-Мексико, США", 295095922, 3, "Спросить о том, когда приедут мать и сестры");

            Assert.That(contact1.CompareTo(contact2), Is.LessThan(0));
            Assert.That(contact2.CompareTo(contact3), Is.LessThan(0));
            Assert.That(contact3.CompareTo(contact1), Is.GreaterThan(0));

            Assert.That(contact1.CompareTo(contact4), Is.LessThan(0));

            Assert.That(contact1.CompareTo(null), Is.GreaterThan(0));

            var contacts = new List<Contact>{ contact3, contact1, contact4, contact2 };
            contacts.Sort();

            Assert.That(contacts[0].Name, Is.EqualTo("Джейн"));
            Assert.That(contacts[0].Surname, Is.EqualTo("Доу"));

            Assert.That(contacts[1].Name, Is.EqualTo("Жанна"));
            Assert.That(contacts[1].Surname, Is.EqualTo("Доу"));

            Assert.That(contacts[2].Name, Is.EqualTo("Герберт"));
            Assert.That(contacts[2].Surname, Is.EqualTo("Людвиг"));

            Assert.That(contacts[3].Name, Is.EqualTo("Джереми"));
            Assert.That(contacts[3].Surname, Is.EqualTo("Уиллис"));
        }

        [Test]
        public void GetInfoTest()
        {
            var contact = CreateTestContact();
            var info = contact.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));
            Assert.That(info[0], Is.EqualTo("Джейн Доу, Работа"));
            Assert.That(info[1], Is.EqualTo("г.Туфорт, Нью-Мексико, США, 235020596"));
            Assert.That(info[2], Is.EqualTo("2"));
            Assert.That(info[3], Is.EqualTo("Свадьба с Жанной, вторник, 12:00"));
        }
    }
}