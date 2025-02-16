using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal static class SortingConditional
    {
        // I have to make overloading methods beacuse every method different in body and signture 
        public static bool CompareAce(int x, int y) { return x > y; }
        public static bool CompareDce(int x, int y) { return x < y; }
        public static bool CompareString(string x, string y) { return x.Length > y.Length; }
        public static bool CheckEvenOrNot(int x ) { return x % 2 == 0; }
    }
}
