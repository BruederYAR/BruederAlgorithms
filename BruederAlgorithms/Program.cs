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
            HeapSort<int> sort = new HeapSort<int>();
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                sort.Items.Add(random.Next(0, 100));
            }
            sort.PrintItems();
            Console.WriteLine();
            sort.MakeSort();
            sort.PrintItems();

            Console.ReadKey();
        }
    }
}
