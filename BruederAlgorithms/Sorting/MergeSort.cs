using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruederAlgorithms.Sorting
{
    public class MergeSort<T> : AlgorithmBase<T> where T : IComparable 
    {
        public MergeSort(IEnumerable<T> Items) : base(Items) { }
        public MergeSort() { }

        public override void MakeSort()
        {
            Items = Sort(Items);
        }

        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1) //Если список состоит из 1 эллемента (сортировка оконченна)           
                return items;

            int mid = items.Count / 2;
            List<T> left = items.Take(mid).ToList(); //Take Взять до mid
            List<T> right = items.Skip(mid).ToList(); //Skip Пропустить mid

            return Merge(Sort(left), Sort(right)); //Рекурсивный вызов
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            int lenght = left.Count + right.Count;
            int leftPointer = 0; //поинтеры для каждой стороны
            int rightPointer = 0;

            List<T> result = new List<T>();

            for(int i = 0; i < lenght; i++)
            {
                if(leftPointer < left.Count && rightPointer < right.Count) //Если один списки не прошли до конца по поинтерам
                {
                    if (Compare(left[leftPointer], right[rightPointer]) == -1) //Если левый меньше
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if(rightPointer < right.Count) //в &&, если левое условие ложное, то правое не проверяется, значит нужно проверить прошло ли правое условие 
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }

            return result;
        }
    }
}
