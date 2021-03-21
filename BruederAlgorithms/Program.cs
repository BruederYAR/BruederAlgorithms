using BruederAlgorithms.Sorting;
using BruederAlgorithms.Search;
using System;
using System.Collections.Generic;

namespace BruederAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSearch<int> sort = new FibonacciSearch<int>();
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                sort.Items.Add(random.Next(0, 100));
            }
            sort.Items.Sort();
            sort.PrintItems(10);
            Console.WriteLine();
            Console.WriteLine(sort.ToFind(55));
            

            Console.ReadKey();
        }

    }
}
