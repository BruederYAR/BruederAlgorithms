using Microsoft.VisualStudio.TestTools.UnitTesting;
using BruederAlgorithms.Search;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BruederAlgorithmsTests.Search
{
    [TestClass]
    public class SearchTests
    {
        List<int> Items = new List<int>();
        int SearchItem { get; set; }

        [TestInitialize]
        public void Init()
        {
            FillRandom();
            SearchItem = 10;
        }

        [TestMethod]
        public void LinearSearchTest()
        {
            LinearSearch<int> linearSearch = new LinearSearch<int>();


            for (int i = 0; i < 100; i++)
            {
                FillRandom();
                linearSearch.Items.Clear();
                linearSearch.Items.AddRange(this.Items);
                Assert.AreEqual(this.Items.IndexOf(this.SearchItem), linearSearch.ToFind(this.SearchItem));
            }
        }

        [TestMethod]
        public void BinarySearchTest()
        {
            BinarySearch<int> binarySearch = new BinarySearch<int>();

            for (int i = 0; i < 100; i++)
            {
                FillRandom();
                Items.Sort();

                binarySearch.Items.Clear();
                binarySearch.Items.AddRange(this.Items);

                int standart = this.Items.BinarySearch(this.SearchItem) < -1 ? -1 : this.Items.BinarySearch(this.SearchItem);
                Assert.AreEqual(standart, binarySearch.ToFind(this.SearchItem));
            }
        }

        [TestMethod]
        public void InterpolationSearchTest()
        {
            InterpolationSearch<int> interpolationSearch = new InterpolationSearch<int>();

            for (int i = 0; i < 100; i++)
            {
                FillRandom();
                this.Items.Sort();

                interpolationSearch.Items.Clear();
                interpolationSearch.Items.AddRange(this.Items);

                if (this.Items.IndexOf(this.SearchItem) != -1 && interpolationSearch.ToFind(this.SearchItem) != -1)
                    Assert.AreEqual(this.Items[this.Items.IndexOf(this.SearchItem)], this.Items[interpolationSearch.ToFind(this.SearchItem)]);
                else
                    if (interpolationSearch.ToFind(this.SearchItem) == -1 && this.Items.IndexOf(this.SearchItem) != -1)
                    Assert.IsTrue(false);
                else if (interpolationSearch.ToFind(this.SearchItem) != -1 && this.Items.IndexOf(this.SearchItem) == -1)
                    Assert.IsTrue(false);
                else if (interpolationSearch.ToFind(this.SearchItem) != -1 && this.Items.IndexOf(this.SearchItem) != -1)
                    Assert.IsTrue(true);
                    
            }
            
        }


        private void FillRandom()
        {
            Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                Items.Add(random.Next(0, 100));
            }         
        }
    }
}
