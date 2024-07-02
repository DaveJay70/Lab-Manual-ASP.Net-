using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int Factorial(int n);

namespace Lab3
{
    internal class Program4
    {
        public void df()
        {
            Factorial f1 = new Factorial(calculateFact);
            Console.WriteLine("Enter Number:-");
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = f1(n);
            Console.WriteLine("Factorial:-" + ans);  
        }
        public int calculateFact(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
