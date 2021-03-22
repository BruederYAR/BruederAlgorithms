using BruederAlgorithms.Sorting;
using BruederAlgorithms.Search;
using BruederAlgorithms.Hashing;
using System;
using System.Collections.Generic;

namespace BruederAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashTableSearch<int> sort = new HashTableSearch<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Random random = new Random();
            //    sort.Items.Add(random.Next(0, 100));
            //}

            //sort.Items.Sort();
            //sort.PrintItems(10);
            //Console.WriteLine();
            //Console.WriteLine(sort.ToFind(55));

            List<int> list = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                list.Add(new Random().Next(100000));
            }

            HashTable<int> hashTable = new HashTable<int>(list);

            int c = hashTable.items.Length;

            hashTable.Add(45);
            hashTable.Add(5775);
            hashTable.Add(3);

            Console.WriteLine(hashTable.Search(4));
            Console.WriteLine(hashTable.Search(45));
            Console.WriteLine(hashTable.Search(5775));
        }

    }
}
