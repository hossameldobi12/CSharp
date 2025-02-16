using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTaskLecture01
{
    internal struct Point
    {
        private double x;
        private double y;
        public double X
        {
            set
            {
                if (value.GetType() != typeof(string))
                {
                    x = value;
                }
            }
            get
            {
                return x;
            }

        }
        public double Y
        {
            set
            {
                if (value.GetType() != typeof(string))
                {
                    y = value;
                }
            }
            get
            {
                return y;
            }
        }
        public double CalculateDistance(Point p)
        {
            double Distance = Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));

            return Distance;
        }
        public Point(double x , double y)
        {
            X = x;
            Y = y;
        }

    }
}