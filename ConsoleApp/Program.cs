using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(1, 3);
            
            MyForEach(data, Console.WriteLine);
        }

        private static void MyForEach<T>(IEnumerable<T> data, Action<T> action)
        {
            foreach (var item in data)
            {
                action(item);
            }
        }
    }
}