using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTaskLecture04
{
    internal class Point : IComparable
    {
        private double x;
        private double y;
        private double z;
        public double X { get;set; }
        public double Y { get;set; }
        public double Z {get; set;}

        public Point() :this (0.0,0.0)
        {
            
        }
        public Point(double x) :this (x,0.0,0.0)
        {
            
        }
        public Point(double x,double y ) :this (x,y,0.0)
        {

        }
        public Point(double x , double y ,double z) 
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }

       

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                throw new Exception("obj is null");
            }
            else
            {
                Point p = (Point)obj;

                if (X > p.X)
                    return 1;
                else if (X < p.X)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
