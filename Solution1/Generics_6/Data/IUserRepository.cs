using Generics_6.Model;

namespace Generics_6.Data
{
    internal interface IUserRepository : IRepository<User>
    {
        User[] FindByName(string name);
    }
}
