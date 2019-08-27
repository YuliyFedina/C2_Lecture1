using System.Collections.Generic;
using System.Linq;
using Generics_1.Model;

namespace Generics_1.Data
{
    internal class ContactRepository
    {
        private readonly List<Contact> _storage = new List<Contact>();

        public void Add(Contact contact)
        {
            _storage.Add(contact);
        }

        public void Remove(Contact contact)
        {
            _storage.Remove(contact);
        }

        public Contact GetById(long id)
        {
            return _storage.FirstOrDefault(o => o.Id == id);
        }
    }
}
