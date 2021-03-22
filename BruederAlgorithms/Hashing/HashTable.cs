using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.Hashing
{
    public class HashTable<T>
    {
        public HashItem<T>[] items;

        public HashTable(int size)
        {
            items = new HashItem<T>[size];

            for(int i = 0; i < items.Length; i++)
            {
                items[i] = new HashItem<T>(i);
            }
        }

        public HashTable(IEnumerable<T> iEnume)
        {
            List<T> list = new List<T>();
            list.AddRange(iEnume);


            items = new HashItem<T>[list.Count];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new HashItem<T>(i);
            }

            AddRange(iEnume);
        }

        public void AddRange(IEnumerable<T> iEnume)
        {
            List<T> list = new List<T>();
            list.AddRange(iEnume);

            for (int i = 0; i < list.Count; i++)
            {
                Add(list[i]);
            }
        }

        public void Add(T item)
        {
            items[GetHash(item)].Items.Add(item);
        }

        public int Search(T item)
        {
            if (items[GetHash(item)].Items.Contains(item))
                return GetHash(item);
            else
                return -1;
        }

        private int GetHash(T item)
        {
            int a = int.Parse(item.ToString().Substring(0, 1)) + item.GetHashCode();
            return a % items.Length;
        }
    }
}
