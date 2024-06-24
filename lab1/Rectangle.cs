using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Rectangle
    {
        int length;
        int breadth;
        public Rectangle()
        {
            Console.WriteLine("Enter length :-");
            this.length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breadth :-");
            this.breadth = Convert.ToInt32(Console.ReadLine());
        }

        public void evaluate()
        {
            int result = (this.length * this.breadth);
            Console.WriteLine("Area of Rectangle :- " + result);
        }
    }
}
