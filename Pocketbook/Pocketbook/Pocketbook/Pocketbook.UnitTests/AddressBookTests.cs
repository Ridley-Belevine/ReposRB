using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using System.Collections.Generic;
using Pocketbook;


namespace Pocketbook.Tests
{
    [TestFixture]
    public class AddressBookTests
    {
        [Test]
        public void Constructor_InitializesPropertiesAndList()
        {
            var contactList = new List<Contact>
            {
                new Contact("Джейн", "Доу", "Работа", "г.Туфорт, Нью-Мексико, США", 235020596, 2, "Свадьба с Жанной, вторник, 12:00"),
                new Contact("Герберт", "Людвиг", "Работа", "г.Штутгарт, Баден-Вюртемберг, Германия", 680030661, 7, "Встретиться и обсудить аспекты лечения"),
                new Contact("Джереми", "Уиллис", "Работа", "г.Бостон, Нью-Джерси, США", 405000577, 1, "Закупиться к празднованию Рождества, Мега Молл, 17:30"),
                new Contact("Делл", "Конагер", "Работа", "г.Харрис, Техас, США", 067922492, 6, "Помочь починить генератор, завтра. До 16:00 не беспокоить"),
            };

            var addressbook = new AddressBook("Записная книжка", contactList);

            Assert.That(addressbook.Name, Is.EqualTo("Записная книжка"));

            Assert.That(addressbook.Count, Is.EqualTo(4));
        }

        [Test]
        public void CountReturnsCorrectQuanitityOfItems()
        {
            var contactList = new List<Contact>
            {
                new Contact("Джейн", "Доу", "Работа", "г.Туфорт, Нью-Мексико, США", 235020596, 2, "Свадьба с Жанной, вторник, 12:00"),
                new Contact("Герберт", "Людвиг", "Работа", "г.Штутгарт, Баден-Вюртемберг, Германия", 680030661, 7, "Встретиться и обсудить аспекты лечения"),
            };

            var addressbook = new AddressBook("Записная книжка #2", contactList);

            Assert.That(addressbook.Count, Is.EqualTo(2));
        }

        [Test]
        public void IEnumerableHelpsIteration()
        {
            var contactList = new List<Contact>
            {
                new Contact("Джейн", "Доу", "Работа", "г.Туфорт, Нью-Мексико, США", 235020596, 2, "Свадьба с Жанной, вторник, 12:00"),
                new Contact("Герберт", "Людвиг", "Работа", "г.Штутгарт, Баден-Вюртемберг, Германия", 680030661, 7, "Встретиться и обсудить аспекты лечения"),            };

            var addressbook = new AddressBook("Проверяемая записная книжка", contactList);

            var iteratedContacts = new List<Contact>();
            foreach (var item in addressbook)
            {
                iteratedContacts.Add(item);
            }
            Assert.That(iteratedContacts.Count, Is.EqualTo(contactList.Count));
            
            for (int i = 0; i < contactList.Count; i++)
            {
                Assert.That(iteratedContacts[i], Is.SameAs(contactList[i]));
            }
        }
    }
}
