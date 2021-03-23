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

            LinearSearchSubSring linearSearch = new LinearSearchSubSring()
            {
                Value = "Forget minutes. It's just 17 seconds. My answer just above is my 2nd high-est voted answer on the site." +
                " In fact I'm here now because someone just voted it again, almost 10 years later." +
                " And the two answers aren't really any different... but mine was posted 17 seconds faster," +
                " and that's meant a 500 vote difference",
                SubValue = "really",
            };

            Console.WriteLine(linearSearch.ToFind());


            //List<int> list = new List<int>();
            //for(int i = 0; i < 100; i++)
            //{
            //    list.Add(new Random().Next(100000));
            //}

            //HashTable<int> hashTable = new HashTable<int>(list);

            //int c = hashTable.items.Length;

            //hashTable.Add(45);
            //hashTable.Add(5775);
            //hashTable.Add(3);

            //Console.WriteLine(hashTable.Search(4));
            //Console.WriteLine(hashTable.Search(45));
            //Console.WriteLine(hashTable.Search(5775));
        }

    }
}
