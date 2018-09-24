using System;
using System.Linq;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Enumerable
                .Range(1, 3)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}