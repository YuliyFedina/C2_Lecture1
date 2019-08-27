using System;
using Generics_6.Data;
using Generics_6.Model;

namespace Generics_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = null };

            var phone = new Phone { Id = 1, PhoneCode = "123", Value = "123124" };

            var userRepository = GetRepository<User, UserValidator>();
            userRepository.Add(user);

            //var contactRepository = GetRepository<Contact>();
            //contactRepository.Add(phone);

            Console.WriteLine(userRepository.GetById(1));
        }

        private static IRepository<TEntity, TValidator> GetRepository<TEntity, TValidator>()
            where TEntity : IEntity
            where TValidator : IValidator<TEntity>, new()
        {
            return new EntityRepository<TEntity, TValidator>();
        }
    }
}
