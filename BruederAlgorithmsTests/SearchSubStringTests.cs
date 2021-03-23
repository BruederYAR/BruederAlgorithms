using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BruederAlgorithms.SearchSubString;

namespace BruederAlgorithmsTests
{
    [TestClass]
    public class SearchSubStringTests
    {
        public string Value { get; set; }
        public string SubValue { get; set; }

        [TestInitialize]
        public void Init()
        {
            this.Value = "Forget minutes. It's just 17 seconds. My answer just above is my 2nd high-est voted answer on the site." +
                " In fact I'm here now because someone just voted it again, almost 10 years later." +
                " And the two answers aren't really any different... but mine was posted 17 seconds faster," +
                " and that's meant a 500 vote difference";

            this.SubValue = "really";
        }

        [TestMethod]
        public void LinearSearchSubSringTest()
        {
            LinearSearchSubSring linearSearch = new LinearSearchSubSring();

            linearSearch.Value = this.Value;
            linearSearch.SubValue = this.SubValue;

            Assert.AreEqual(Value.IndexOf(this.SubValue), linearSearch.ToFind());
        }

        [TestMethod]
        public void KMPSearchSubStringTest()
        {
            KMPSearchSubString kMPSearch = new KMPSearchSubString();

            kMPSearch.Value = this.Value;
            kMPSearch.SubValue = this.SubValue;

            Assert.AreEqual(Value.IndexOf(this.SubValue), kMPSearch.ToFind());
        }

    }
}
