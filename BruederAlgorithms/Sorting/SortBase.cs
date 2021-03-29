using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms
{
    public class SortBase<T> where  T: IComparable
    {

        public SortBase(IEnumerable<T> Items) { this.Items.AddRange(Items); }
        public SortBase() { }

        public List<T> Items { get; set; } = new List<T>();

        public virtual void MakeSort()
        {
            Items.Sort(); 
        }


        public event EventHandler<Tuple<T, T>> CompareEvent;
        public int ComparisonCount { get; protected set; } = 0;
        protected int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            ComparisonCount++;
            return a.CompareTo(b);
        }



    }
}
