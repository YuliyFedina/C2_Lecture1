using System.Collections.Generic;
using System.Linq;
using Generics_1.Model;

namespace Generics_1.Data
{
    internal class UserRepository
    {
        private readonly List<User> _storage = new List<User>();

        public void Add(User user)
        {
            _storage.Add(user);
        }

        public void Remove(User user)
        {
            _storage.Remove(user);
        }

        public User GetById(long id)
        {
            return _storage.FirstOrDefault(o => o.Id == id);
        }
    }
}
