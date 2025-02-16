using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTaskLecture03
{
    internal class Circle : ICircle

    {
        public double Radious
        {
            set; get;
        }
        public double Area
        {
            get
            {
                return Radious * Radious * Math.PI;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Area is {Area},AND the Radious is {Radious}");
        }
    }
}
