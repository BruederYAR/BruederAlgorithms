using System;
using System.Collections.Generic;
using System.Text;

namespace BruederAlgorithms.SearchSubString
{
    public class SearchSubStringBase 
    {
        public string Value { get; set; }
        public string SubValue { get; set; }

        public SearchSubStringBase(IEnumerable<char> Value, IEnumerable<char> SubValue) { this.Value = new string(((List<char>)Value).ToArray()); this.SubValue = new string(((List<char>)SubValue).ToArray()); }
        public SearchSubStringBase(IEnumerable<char> Value, string SubValue) { this.Value = new string(((List<char>)Value).ToArray()); this.SubValue = SubValue; }
        public SearchSubStringBase(string Value, IEnumerable<char> SubValue) { this.Value = Value; this.SubValue = new string(((List<char>)SubValue).ToArray()); }
        public SearchSubStringBase(string Value, string SubValue) { this.Value = Value; this.SubValue = SubValue; }
        public SearchSubStringBase() { }

        public virtual int ToFind()
        {
            return -1;
        }
    }
}
