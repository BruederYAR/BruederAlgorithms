using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.SearchSubString
{
    public class LinearSearchSubSring : SearchSubStringBase
    {
        public LinearSearchSubSring(IEnumerable<char> Value, IEnumerable<char> SubValue) : base(Value, SubValue) { }
        public LinearSearchSubSring(IEnumerable<char> Value, string SubValue) : base(Value, SubValue) { }
        public LinearSearchSubSring(string Value, IEnumerable<char> SubValue) : base(Value, SubValue) { }
        public LinearSearchSubSring(string Value, string SubValue) : base(Value, SubValue) { }
        public LinearSearchSubSring() { }

        public override int ToFind()
        {
            return Search();
        }

        private int Search()
        {
            int result = -1;//Если вхождение подстроки не найдено
            for (int i = 0; i < this.Value.Length - this.SubValue.Length + 1; i++)
            {
                for (int j = 0; j < this.SubValue.Length; j++)
                {
                    if (this.SubValue[j] != this.Value[i + j])
                    {
                        break;
                    }
                    else if (j == this.SubValue.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return result;
        }
    }
}
