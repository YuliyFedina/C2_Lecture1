using System;
using Generics_4.Data;
using Generics_4.Model;

namespace Generics_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Name" };

            var phone = new Phone { Id = 1, PhoneCode = "123", Value = "123124" };

            var userRepository = new EntityRepository<User>();
            userRepository.Add(user);

            var contactRepository = new EntityRepository<Contact>();
            contactRepository.Add(phone);

            Console.WriteLine(contactRepository.GetById(1));

        }
    }
}
