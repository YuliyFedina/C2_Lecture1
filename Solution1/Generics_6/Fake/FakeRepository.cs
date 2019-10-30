using System;
using Generics_6.Data;
using Generics_6.Model;

namespace Generics_6.Fake
{
    internal class FakeRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        public void Add(TEntity contact)
        {
            
        }

        public void Remove(TEntity contact)
        {
        }

        public TEntity GetById(long id)
        {
            throw new NotImplementedException();
        }

        public TEntity[] GetAll()
        {
            return new TEntity[0];
        }
    }
}
