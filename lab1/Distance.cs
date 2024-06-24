using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Distance
    {
        public double Dist1;
        public double Dist2;
        public double Dist3;
        public Distance()
        {
            Console.WriteLine("Please enter Distance1 : ");
            this.Dist1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Distance2 : ");
            this.Dist2 = Convert.ToDouble(Console.ReadLine());
            Dist3 = 0;
        }

        public void AddDistances()
        {
            Dist3 = Dist1 + Dist2;
        }

        public void DisplayAddition()
        {
            Console.WriteLine("Addition of Distances: " + Dist3);
        }
    }
}
