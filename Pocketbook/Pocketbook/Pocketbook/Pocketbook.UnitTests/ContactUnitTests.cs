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