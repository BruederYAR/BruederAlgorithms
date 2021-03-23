using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.SearchSubString
{
    public class KMPSearchSubString : SearchSubStringBase
    {
        public KMPSearchSubString(IEnumerable<char> Value, IEnumerable<char> SubValue) : base(Value, SubValue) { }
        public KMPSearchSubString(IEnumerable<char> Value, string SubValue) : base(Value, SubValue) { }
        public KMPSearchSubString(string Value, IEnumerable<char> SubValue) : base(Value, SubValue) { }
        public KMPSearchSubString(string Value, string SubValue) : base(Value, SubValue) { }
        public KMPSearchSubString() { }

        public override int ToFind()
        {
            return Search();
        }

        private int Search()
        {
            int[] pf = GetPrefix(this.SubValue);
            int index = 0;

            for (int i = 0; i < this.Value.Length; i++)
            {
                while (index > 0 && this.SubValue[index] != this.Value[i])
                {
                    index = pf[index - 1];
                }
                if (this.SubValue[index] == this.Value[i]) index++;
                if (index == this.SubValue.Length)
                {
                    return i - index + 1;
                }
            }
            return -1;
        }

        private int[] GetPrefix(string s)
        {
            int[] result = new int[s.Length];
            result[0] = 0;
            int index = 0;

            for (int i = 1; i < s.Length; i++)
            {
                while (index >= 0 && s[index] != s[i]) { index--; }
                index++;
                result[i] = index;
            }

            return result;
        }
    }
}
