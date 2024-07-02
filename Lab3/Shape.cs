using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Shape
    {
        public double Area(double side)
        {
            return side * side;
        }

        
        public double Area(double length, double breadth)
        {
            return length * breadth;
        }

        
        public double Area(double radius, bool isCircle)
        {
            if (isCircle)
            {
                return 3.14159 * radius * radius;
            }
            return 0;
        }
    }
}
