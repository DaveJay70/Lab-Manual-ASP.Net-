using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface ShapeInterface
    {
        double Circle();

        double Triangle();

        double Square();
    }
    internal class Shape: ShapeInterface
    {
        double Radius, Base, Height, Side;
        public void Get_data()
        {
            Console.WriteLine("Enter Radius :-");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Base :-");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height :-");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Side :-");
            Side = Convert.ToDouble(Console.ReadLine());
        }
        public double Circle()
        {
            return Math.PI * Radius * Radius;
        }

        public double Square()
        {
            return Side * Side;
        }

        public double Triangle()
        {
            return (0.5 * Base * Height);
        }
    }
}
