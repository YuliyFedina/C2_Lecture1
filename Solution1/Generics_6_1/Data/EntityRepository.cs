using System;
using System.Collections.Generic;
using System.Linq;
using Generics_6.Model;

namespace Generics_6.Data
{
    internal class EntityRepository<TEntity, TValidator> : IRepository<TEntity, TValidator>
        where TEntity : IEntity
        where TValidator : IValidator<TEntity>, new()
    {
        private readonly List<TEntity> _storage = new List<TEntity>();

        private readonly TValidator _validator = new TValidator();

        public void Add(TEntity contact)
        {
            if (!_validator.Validate(contact))
            {
                throw new InvalidOperationException();
            }
            _storage.Add(contact);
        }

        public void Remove(TEntity contact)
        {
            _storage.Remove(contact);
        }

        public TEntity GetById(long id)
        {
            return _storage.FirstOrDefault(o => o.Id == id);
        }

        public TEntity[] GetAll()
        {
            return _storage.ToArray();
        }
    }
}
