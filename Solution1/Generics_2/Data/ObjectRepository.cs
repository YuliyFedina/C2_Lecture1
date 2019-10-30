using System.Collections.Generic;
using System.Linq;
using Generics_2.Model;

namespace Generics_2.Data
{
    internal class ObjectRepository<TEntity> where TEntity : IEntity
    {
        private readonly List<TEntity> _storage = new List<TEntity>();

        public void Add(TEntity value)
        {
            _storage.Add(value);
        }

        public void Remove(TEntity value)
        {
            _storage.Remove(value);
        }

        public TEntity GetById(long id)
        {
            return _storage.FirstOrDefault(o => o.Id == id);
            //TODO: как-то реализовать поиск по Id
            return default(TEntity);
        }

        public TEntity[] GetAll()
        {
            return _storage.ToArray();
        }
    }
}
