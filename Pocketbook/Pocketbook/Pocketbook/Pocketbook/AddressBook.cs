using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocketbook
{
    public class AddressBook : IEnumerable<Contact>
    {
        public string Name { get; set; }
        public int Count
        {
            get { return _contactList.Count; }
        }
        private readonly List<Contact> _contactList;
        public AddressBook(string name, IEnumerable<Contact> contacts)
        {
            Name = name;
            _contactList = new List<Contact>();

            foreach (var item in contacts)
            {
                if (!_contactList.Contains(item))
                {
                    _contactList.Add(item);
                }
            }
        }
        public IEnumerator<Contact> GetEnumerator()
        {
            return _contactList.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
