using System.Collections.Generic;
using System.Linq;
using Generics_1.Model;

namespace Generics_1.Data
{
    internal class Repository<T> where T : IEntity
    {
        private readonly List<T> _storage = new List<T>();

        public void Add(T value)
        {
            _storage.Add(value);
        }

        public void Remove(T value)
        {
            _storage.Remove(value);
        }

        public T GetById(long id)
        {
           return _storage.FirstOrDefault(o => o.Id == id);
        }
    }
}