using System;
using Generics_1.Data;
using Generics_1.Model;

namespace Generics_1
{
    class Program
    {
        static void Main()
        {
            var user = new User {Id = 1, Name = "Name"};

            var phone = new Phone {Id = 1, PhoneCode = "123", Value = "123124"};

            var userRepository = new Repository<User>();
            userRepository.Add(user);

            var contactRepository = new Repository<Contact>();
            contactRepository.Add(phone);
            
            Console.WriteLine($"{contactRepository.GetById(1)}");
            Console.ReadLine();
        }
    }
}
