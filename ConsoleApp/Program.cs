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

        private static void MyForEach(IEnumerable<int> data, Action<int> action)
        {
            foreach (var item in data)
            {
                action(item);
            }
        }
    }
}