﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string b = null;

            Console.WriteLine(GetStringValue(a));

            Console.WriteLine(GetStringReference(b));

            var array = ArrayExtensions.Generate<string>(5);

            var list = new List<int>();
            var dict = new Dictionary<string, int>();

            Console.ReadLine();

        }

        private static string GetStringReference<T>(T value)
        where T: class 
        {
            if (value == null)
                return null;
            return value.ToString();
        }

        private static string GetStringValue<T>(T value)
        where T: struct
        {
            return value.ToString();
        }

        private static void Print<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}