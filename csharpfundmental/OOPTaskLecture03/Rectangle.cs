using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTaskLecture03
{
    internal class Rectangle : IRectangle
    {
        public double Area { get { return length * width; } }

        public double length { set; get; }
        public double width { set; get; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Area of the rectanle is {Area}, with the length {length} and the width is {width}");
        }
    }
}
