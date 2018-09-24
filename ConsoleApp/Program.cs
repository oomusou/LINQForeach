using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Enumerable
                .Range(1, 3)
                .MyForEach(Console.WriteLine);
            
        }

        private static void MyForEach<T>(this IEnumerable<T> data, Action<T> action)
        {
            foreach (var item in data)
            {
                action(item);
            }
        }
    }
}