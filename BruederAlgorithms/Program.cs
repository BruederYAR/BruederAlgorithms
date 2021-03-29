using BruederAlgorithms.Sorting;
using BruederAlgorithms.Search;
using BruederAlgorithms.Hashing;
using BruederAlgorithms.SearchSubString;
using System;
using System.Collections.Generic;

namespace BruederAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); //Список с рандомными значениями
            FillRandomList(ref list);
            list.Sort();

            //Применяю стратегию
            Console.WriteLine(AlgorithmInterface.ToFind(new LinearSearch<int>(list), 10));
            Console.WriteLine(AlgorithmInterface.ToFind(new BinarySearch<int>(list), 10));
            Console.WriteLine(AlgorithmInterface.ToFind(new FibonacciSearch<int>(list), 10));

            Console.WriteLine();
            Console.WriteLine(AlgorithmInterface.ToFindSubString(new BMSearchSubString("this is test text", "test")));
            Console.WriteLine(AlgorithmInterface.ToFindSubString(new KMPSearchSubString("this is test text", "text")));

            Console.WriteLine();
            FillRandomList(ref list);
            PrintItems((List<int>)AlgorithmInterface.Sort(new MergeSort<int>(list)), 10);
            Console.WriteLine();
            PrintItems((List<int>)AlgorithmInterface.Sort(new HeapSort<int>(list)), 10);

            Console.ReadKey();                   
        }

        static void FillRandomList(ref List<int> list, int values = 100, int max = 50)
        {
            list.Clear();
            for (int i = 0; i < values; i++)
            {
                list.Add(new Random().Next(max));
            }
        }

        static void PrintItems(List<int> Items,int tab = 1)
        {
            int a = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                Console.Write($"{Items[i]} ");
                if (a >= tab)
                {
                    // Console.WriteLine();
                    a = 0;
                }
                a++;
            }
            Console.WriteLine();
        }

    }
}
