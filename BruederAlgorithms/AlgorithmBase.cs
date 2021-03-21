using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms
{
    public class AlgorithmBase<T> where T: IComparable
    {

        public AlgorithmBase(IEnumerable<T> Items) { this.Items.AddRange(Items); }
        public AlgorithmBase() { }

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

        public void PrintItems(int tab = 1) 
        {
            int a = 0;
            for (int i = 0; i < this.Items.Count; i++)
            {
                Console.Write($"{this.Items[i]} ");
                if(a >= tab)
                {
                    Console.WriteLine();
                    a = 0;
                }
                a++;
            }
             
        }

        //public void FillRandom(int count, int max = 100)
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < count; i++)
        //        Items.Add(random.Next(0, max));
        //}
    }
}
