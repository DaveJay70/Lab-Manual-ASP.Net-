using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class EvenException
    {
        public void ShowData()
        {
            try
            {
                Console.WriteLine("Enter Number:-");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 != 0)
                {
                    throw new ArgumentException("Number is not even...");
                }
                else
                {
                    Console.WriteLine(number+" is Even");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("An error occurred:: " + ex.Message);
            }
        }
    }
}
