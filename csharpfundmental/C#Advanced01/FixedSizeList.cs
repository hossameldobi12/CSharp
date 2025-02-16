using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01
{
    internal class FixedSizeList<T>
    {
        ArrayList list;
        int counter = 0;
        public int Capcity { get; set; }
        public FixedSizeList(int c)
        {
            Capcity = c;
            list = new ArrayList(Capcity);
        }
        public void Add(T item)

        {
            if (counter <= Capcity)
            {
                list.Add(item);
                counter++;
            }
            else
            {
                throw new Exception("the capcity is full");
            }
        }
        public T Get(int index)
        {
        
            if (index > list.Count)
            {
                throw new Exception("th index out of range");
            }
            return (T)list[index];

        }
    }

}
