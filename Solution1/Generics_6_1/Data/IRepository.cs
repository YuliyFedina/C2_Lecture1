using Generics_6.Model;

namespace Generics_6.Data
{
    internal interface IRepository<TEntity, TValidator>
        where TEntity : IEntity
        where TValidator : IValidator<TEntity>
    {
        void Add(TEntity contact);

        void Remove(TEntity contact);

        TEntity GetById(long id);

        TEntity[] GetAll();
    }
}
