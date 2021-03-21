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
      
        private void Hiapify(List<T> arr, int n, int i)
        {
            int largest = i; // Инициализируем наибольший элемент как корень
            int l = 2 * i + 1; // Левый эллемент
            int r = 2 * i + 2; // Правый эллемент

            if (l < n && Compare(arr[largest], arr[l])==-1) // Если левый дочерний элемент больше корня и индекс левого элемента не больше максимального индекса
                largest = l;

            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (r < n && Compare(arr[largest], arr[r])==-1)
                largest = r;

            // Если самый большой элемент не корень
            if (largest != i)
            {
                T swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                Hiapify(arr, n, largest);
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
