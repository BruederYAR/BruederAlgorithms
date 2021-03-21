using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.Search
{
    public class InterpolationSearch<T> : SearchBase<T>
    {
        public InterpolationSearch(IEnumerable<T> List) : base(List) { }
        public InterpolationSearch() { }

        public override int ToFind(T item)
        {
            Items.Sort();
            return Search(item);
        }

        private int Search(T item)
        { 
            int low = 0;
            int high = this.Items.Count-1;
            int mid;

            while (Convert.ToInt32(this.Items[low]) <= Convert.ToInt32(item) && Convert.ToInt32(this.Items[high]) >= Convert.ToInt32(item)) //Пока не выйдем за границу последовательности
            {
                mid = low + ( 
                    (Convert.ToInt32(item) - Convert.ToInt32(this.Items[low]) ) * (high - low)) 
                    / ( Convert.ToInt32(this.Items[high]) - Convert.ToInt32(this.Items[low])); //Формула предстказывающая где может находится инкомый эллемент

                if (greaterThan(item, this.Items[mid])) //Если не дошли до эллемента
                    low = mid + 1;
                else if (greaterThan(this.Items[mid], item)) //Если зашли за элемент
                    high = mid - 1;
                else if (item.Equals(this.Items[mid])) //Эллемент найден
                {
                    return mid;
                }
            }
            return -1; //Эллемент не найден 
        }
    }
}
