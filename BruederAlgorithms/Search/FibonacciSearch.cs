using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.Search
{
    public class FibonacciSearch<T> : SearchBase<T> 
    {
        public FibonacciSearch(IEnumerable<T> List) : base(List) { }
        public FibonacciSearch() { }

        public override int ToFind(T item)
        {
            Items.Sort();
            return Search(item);
        }

        private int Search(T item)
        {
            /*Инициализировать числа Фибоначчи */
            int fibMMm2 = 0; // (м-2) -ый номер Фибоначчи
            int fibMMm1 = 1; // (m-1) -ый номер Фибоначчи

            int fibM = fibMMm2 + fibMMm1; // м Фибоначчи

            /*fibM собирается хранить самые маленькие
            Число Фибоначчи, большее или равное this.Items.Count-1 */

            while (fibM < this.Items.Count-1)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }

            // Отмечает удаленный диапазон спереди
            int offset = -1;

            /*пока есть элементы для проверки.
            Обратите внимание, что мы сравниваем this.Items[fibMm2] с item.
            Когда fibM становится 1, fibMm2 становится 0 */

            while (fibM > 1)
            {
                int i = Math.Min(offset + fibMMm2, this.Items.Count-1 - 1); // Проверяем, является ли fibMm2 действительным местоположением

                /*Если х больше значения в
                индекс fibMm2, вырезать массив подмассива
                от смещения до i */
                if (greaterThan(item, this.Items[i]))
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }
                /*Если х больше, чем значение в индексе
               fibMm2, вырезать подрешетку после i + 1 */
                else if (greaterThan(this.Items[i],item))
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }

                /*элемент найден.индекс возврата */
                else return i;
            }

            /*сравнение последнего элемента с item */
            if (fibMMm1 == 1 && this.Items[offset + 1].Equals(item))
                return offset + 1;

            /*элемент не найден. возврат - 1 */
            return -1;
        }
    }
}
