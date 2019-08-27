using Generics_6.Model;

namespace Generics_6.Data
{
    internal class UserValidator:IValidator<User>
    {
        public bool Validate(User entity)
        {
            return entity.Name != null;
        }
    }
}
