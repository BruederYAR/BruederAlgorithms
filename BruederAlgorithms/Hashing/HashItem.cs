using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.Hashing
{
    public class HashItem<T>
    {
        public int Key { get; set; }
        public List<T> Items { get; set; }

        public HashItem(int Key)
        {
            this.Key = Key;
            Items = new List<T>();
        }
    }
}
