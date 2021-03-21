﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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


            for(int i = 0; i < 100; i++)
            {
                FillRandom();
                linearSearch.Items.Clear();
                linearSearch.Items.AddRange(this.Items);
                Assert.AreEqual(this.Items.IndexOf(this.SearchItem), linearSearch.ToFind(this.SearchItem));
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
