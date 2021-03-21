using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.Search
{
    public class LinearSearch<T> : SearchBase<T>
    {
        public LinearSearch(IEnumerable<T> Items) : base(Items) { }
        public LinearSearch() { }

        public override int ToFind(T item)
        {
            return Search(item);
        }

        private int Search(T item)
        {
            int index = -1;
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

    }
}
