using System.Collections.Generic;

namespace Generics_2.Model
{
    internal class User
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Contact> Contacts { get; private set; }

        public User()
        {
            Contacts = new HashSet<Contact>();
        }
    }
}
