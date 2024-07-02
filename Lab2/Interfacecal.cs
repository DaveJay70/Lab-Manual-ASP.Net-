using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface MyInterface
    {
        public void Addition();
        public void Subtraction();

    }
    internal class Result :MyInterface
    {
        int a, b,c;
        public void getnumber()
        {
            Console.WriteLine("Enter Number 1 :-");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 :-");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public void Addition()
        {
            getnumber();
            
            c = a + b;
            Console.WriteLine("Addition is :-"+c);
        }
        public void Subtraction()
        {
            getnumber();
            c = a - b;
            Console.WriteLine("Subtraction is :-"+c);
        }


    }
}
