using Generics_6.Model;

namespace Generics_6.Data
{
    internal class ContactValidator: IValidator<Contact>
    {
        public bool Validate(Contact entity)
        {
            return entity.Value != null;
        }
    }
}
