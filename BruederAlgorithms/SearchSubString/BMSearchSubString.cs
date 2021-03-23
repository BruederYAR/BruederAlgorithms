using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.SearchSubString
{
    public class BMSearchSubString : SearchSubStringBase
    {
        public BMSearchSubString(IEnumerable<char> Value, IEnumerable<char> SubValue) : base(Value, SubValue) { }
        public BMSearchSubString(IEnumerable<char> Value, string SubValue) : base(Value, SubValue) { }
        public BMSearchSubString(string Value, IEnumerable<char> SubValue) : base(Value, SubValue) { }
        public BMSearchSubString(string Value, string SubValue) : base(Value, SubValue) { }
        public BMSearchSubString() { }

        public override int ToFind()
        {
            return Search();
        }
        private int Search()
        {
            int sl, ssl;
            int result = -1;
            sl = this.Value.Length;
            ssl = this.SubValue.Length;

            int i, Pos;
            int[] BMT = new int[256];
            for (i = 0; i < 256; i++)
                BMT[i] = ssl;
            for (i = ssl - 1; i >= 0; i--)
                if (BMT[(short)(this.SubValue[i])] == ssl)
                    BMT[(short)(this.SubValue[i])] = ssl - i - 1;
            Pos = ssl - 1;
            while (Pos < sl)
                if (this.SubValue[ssl - 1] != this.Value[Pos])
                    Pos = Pos + BMT[(short)(this.Value[Pos])];
                else
                    for (i = ssl - 2; i >= 0; i--)
                    {
                        if (this.SubValue[i] != this.Value[Pos - ssl + i + 1])
                        {
                            Pos += BMT[(short)(this.Value[Pos - ssl + i + 1])] - 1;
                            break;
                        }
                        else
                          if (i == 0)
                            return Pos - ssl + 1;
                    }
            return result;
        }


    }
}
