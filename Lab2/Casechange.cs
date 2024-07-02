using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Casechange
    {
        public void caseChange()
        {
            Console.Write("Enter Character : ");
            Char c = Convert.ToChar(Console.ReadLine());

            Char newChar = c.ToString().ToUpper().ToCharArray()[0];
            Console.WriteLine("Changed Character : " + newChar);
        }
    }
}
