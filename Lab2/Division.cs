using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Division
    {
        int num1, num2;
        public void  showException()
        {

            try
            {
                
                Console.WriteLine("Enter Number 1");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number 2");
                num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result is:"+ result);

            }
            catch(DivideByZeroException ex){

                Console.WriteLine(ex.Message);
                Console.WriteLine("Divide by zero exception");
            }
        }
    }
}
