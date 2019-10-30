namespace Generics_6.Data
{
    internal interface IValidator<in TEntity>
    {
        bool Validate(TEntity entity);
    }
}
