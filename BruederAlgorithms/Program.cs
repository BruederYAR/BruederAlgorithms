using BruederAlgorithms.Sorting;
using System;
using System.Collections.Generic;

namespace BruederAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort<int> mergeSort = new MergeSort<int>();

            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                mergeSort.Items.Add(random.Next(0, 1000));
            }

            mergeSort.PrintItems(10);
            mergeSort.MakeSort();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            mergeSort.PrintItems(10);

        }
    }
}
