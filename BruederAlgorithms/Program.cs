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
            InterpolationSearch<int> Sort = new InterpolationSearch<int>();

            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                Sort.Items.Add(random.Next(0, 100));
            }

            Sort.Items.Sort();
            Sort.PrintItems(10);

            Console.WriteLine();
            Console.WriteLine(Sort.ToFind(6));
            Console.WriteLine(Sort.Items.BinarySearch(6));


        }
    }
}
