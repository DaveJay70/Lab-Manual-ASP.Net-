using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void calc(double a,double b);

namespace Lab3
{
    internal class Calculater
    {
        public void dc()
        {
            calc c1 = new calc(addition);
            calc c2 = new calc(subtraction);
            calc c3 = new calc(multiplication);
            calc c4 = new calc(division);

            Console.WriteLine("Enter Number 1:-");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2:-");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter op:-");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    addition(a, b);
                    break;
                case '-':
                    subtraction(a, b);
                    break;
                case '*':
                    multiplication(a, b);
                    break;
                case '/':
                    division(a, b);
                    break;
                default:
                    Console.WriteLine("Invaild Opration");
                    break;
            }



        }
        public static void addition(double a,double b)
        {
            Console.WriteLine("Addition is:-" + (a + b));
        }
        public  static void  subtraction(double a, double b)
        {
            Console.WriteLine("Subtraction is:-" +( a - b));
        }
        public  static void multiplication(double a, double b)
        {
            Console.WriteLine("Multiplication is:-" + (a * b));
        }
        public  static void division(double a, double b)
        {
            Console.WriteLine("Division is:-" +( a / b));
        }

    }
}
