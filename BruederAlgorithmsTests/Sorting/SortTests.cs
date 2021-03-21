using Microsoft.VisualStudio.TestTools.UnitTesting;
using BruederAlgorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BruederAlgorithms.Sorting.Tests
{
    [TestClass()]
    public class SortTests
    {
        List<int> Items = new List<int>();
        List<int> SortedItems = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                Items.Add(random.Next(0, 1000));
            }

            SortedItems.Clear();
            SortedItems.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            //arrange
            var merge = new MergeSort<int>();

            merge.Items.AddRange(Items);

            //act
            merge.MakeSort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], merge.Items[i]);
            }
        }


    }
}