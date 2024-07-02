using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class indexout
    {
        int[] arr = new int[5];

        public void showindex()
        {
            try
            {
                for (int i = 0; i < arr.Length+1; i++)
                {
                    Console.WriteLine("Enter Number :-");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                
               
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Index out of range exception");
            }
        }
    }
}
