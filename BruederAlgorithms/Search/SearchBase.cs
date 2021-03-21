using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BruederAlgorithms.Search
{
    public class SearchBase<T> 
    {
        public SearchBase(IEnumerable<T> Items) { this.Items.AddRange(Items); }
        public SearchBase() { }

        public List<T> Items { get; set; } = new List<T>();

        public virtual int ToFind(T item)
        {
            return -1;
        }

        public void PrintItems(int tab = 1)
        { 
            int a = 0;
            for (int i = 0; i < this.Items.Count; i++)
            {
                Console.Write($"{this.Items[i]} ");
                if (a >= tab)
                {
                    Console.WriteLine();
                    a = 0;
                }
                a++;
            }
        }

        static SearchBase()
        {
            ParameterExpression paramOne = Expression.Parameter(typeof(T), "one");
            ParameterExpression paramTwo = Expression.Parameter(typeof(T), "two");

            greaterThan = (Func<T, T, bool>)Expression.Lambda(Expression.GreaterThan(paramOne, paramTwo), paramOne, paramTwo).Compile();
        }
        public static readonly Func<T, T, bool> greaterThan;
    }
}
