using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01
{
    internal class Ranges<T> where T : IComparable<T>
    {
        private T min;
        private T max;
        public T Min { get { return min; } set { min = value; } }
        public T Max { get { return max; } set { max = value; } }

        public Ranges( T Minmum , T maximum)
        {
            Min = Minmum;
            Max = maximum;
        }
        public bool ValueIsInRange(T value)
        {
            return (value.CompareTo(Min) >= 0) && (value.CompareTo(Max) <= 0);     
        }
        public T length ()
        {
            dynamic Maximum = Max;
            dynamic  Minmum = Min;
            return Maximum - Minmum;
        }
    }
}
