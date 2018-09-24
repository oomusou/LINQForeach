using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(1, 3);

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}