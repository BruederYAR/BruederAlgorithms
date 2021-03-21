using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruederAlgorithms.Sorting
{
    public class HeapSort<T> : SortBase<T> where T : IComparable
    {
        public HeapSort(IEnumerable<T> Items) : base(Items) { }
        public HeapSort() { }

        public override void MakeSort()
        {
            Items = Sort(Items);
        }
      
        private void Hiapify(List<T> items, int n, int i)
        {
            int largest = i; // Инициализируем наибольший элемент как корень
            int left = 2 * i + 1; // Левый эллемент
            int right = 2 * i + 2; // Правый эллемент

            if (left < n && Compare(items[largest], items[left])==-1) // Если левый дочерний элемент больше корня и индекс левого элемента не больше максимального индекса
                largest = left;

            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (right < n && Compare(items[largest], items[right])==-1)
                largest = right;

            // Если самый большой элемент не корень
            if (largest != i)
            {
                T swap = items[i];
                items[i] = items[largest];
                items[largest] = swap;

                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                Hiapify(items, n, largest);
            }
        }
       
        private List<T> Sort(List<T> arr)
        {
            int n = arr.Count; //Максимальное кол-во элементов
           
            // Построение кучи (перегруппируем массив)
            for (int i = n / 2 - 1; i >= 0; i--)
                Hiapify(arr, n, i);

            // Один за другим извлекаем элементы из кучи
            for (int i = n - 1; i >= 0; i--)
            {
                // Перемещаем текущий корень в конец
                T temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // вызываем процедуру heapify на уменьшенной куче
                Hiapify(arr, i, 0);
            }
            return arr;
        }
    }
}
