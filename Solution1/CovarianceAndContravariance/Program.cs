using System;
using System.Collections.Generic;

namespace CovarianceAndContravariance
{
    class Program
    {
        private static void Main(string[] args)
        {
            var phoneCollection1 = new CovariantClass<Phone>();
            DoSmth(phoneCollection1);


            var set = new HashSet<Phone>(new ContactComparer());

            set.Add(new Phone { Value = "1" });
            set.Add(new Phone { Value = "1" });

            Console.WriteLine(set.Count);
        }

        private static void DoSmth(ICovariantInterface<Contact> collection)
        {
            Console.WriteLine("DoSmth");
        }


        private class ContactComparer : IEqualityComparer<Contact>
        {
            public bool Equals(Contact x, Contact y)
            {
                return x.Value == y.Value;
            }

            public int GetHashCode(Contact obj)
            {
                return obj.Value.GetHashCode();
            }
        }
    }
}
