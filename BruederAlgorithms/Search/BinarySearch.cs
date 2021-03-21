using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BruederAlgorithms.Search
{
    public class BinarySearch<T> : SearchBase<T>
    {
        public BinarySearch(IEnumerable<T> Items) : base(Items) { }
        public BinarySearch() { }

        public override int ToFind(T item)
        {
            Items.Sort();

            return Search(item, 0, Items.Count);

        }

        private int Search(T item, int first, int last)
        {
            //границы сошлись
            if (first > last)
            {
                //элемент не найден
                return -1;
            }

            //средний индекс подмассива
            int middle = (first + last) / 2;
            //значение в средине подмассива
            T middleItem = Items[middle];

            if (middleItem.Equals(item))
            {
                return middle;
            }
            else
            {
                if (greaterThan(middleItem, item)) //Если средний item больше item в поиске 
                {
                    //рекурсивный вызов поиска для левого подмассива
                    return Search(item, first, middle - 1);
                }
                else
                {
                    //рекурсивный вызов поиска для правого подмассива
                    return Search(item, middle + 1, last);
                }
            }
        }




    }
}
