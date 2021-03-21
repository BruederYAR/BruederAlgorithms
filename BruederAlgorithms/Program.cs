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
            LinearSearch<int> mergeSort = new LinearSearch<int>();

            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                mergeSort.Items.Add(random.Next(0, 100));
            }

            mergeSort.PrintItems(10);
            Console.WriteLine();
            Console.WriteLine(mergeSort.ToFind(6));
            Console.WriteLine(mergeSort.Items.IndexOf(6));

        }
    }
}
