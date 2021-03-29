using System;
using System.Collections.Generic;
using System.Text;

using BruederAlgorithms.Search;
using BruederAlgorithms.SearchSubString;
using BruederAlgorithms.Sorting;

namespace BruederAlgorithms
{
    public static class AlgorithmInterface
    {
        public static IEnumerable<T> Sort<T>(SortBase<T> sort) where T : IComparable
        {
            IEnumerable<T> result = null;
            if (sort != null && sort.Items.Count != 0)
            {
                sort.MakeSort();
                result = sort.Items;
            }
            else
                throw new Exception("sort obj null or sort items count = 0");
            return result;
        }

        public static int ToFindSubString(SearchSubStringBase search)
        {
            int result = -1;
            if (search != null && search.SubValue != null)
            {
                result = search.ToFind();
            }
            else
                throw new Exception("search obj null or search subValue null");
            return result;
        }

        public static int ToFind<T>(SearchBase<T> search, T item)
        {
            int result = -1;
            if (search != null && search.Items.Count != 0)
                result = search.ToFind(item);
            else
                throw new Exception("search obj null or search values = 0");
            return result;
        }
    }
}
