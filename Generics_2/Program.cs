using System;
using Generics_2.Data;
using Generics_2.Model;

namespace Generics_2
{
    class Program
    {
        static void Main()
        {
            var user = new User { Id = 1, Name = "Name" };

            var phone = new Phone { Id = 1, PhoneCode = "123", Value = "123124" };

            var userRepository = new ObjectRepository<User>();
            userRepository.Add(user);

            var contactRepository = new ObjectRepository<Phone>();
            contactRepository.Add(phone);

            foreach (var value in contactRepository.GetAll())
            {
                var contact = (Contact)value;
                Console.WriteLine(contact.Value);
            }
            contactRepository.Add(phone);

            foreach (var value in contactRepository.GetAll())
            {
                var contact = (Contact)value;
                Console.WriteLine(contact.Value);
            }

            Console.ReadLine();
        }
    }
}
