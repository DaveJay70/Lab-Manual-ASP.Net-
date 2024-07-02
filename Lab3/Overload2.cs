using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Overload2
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Addition(int a, int b,int c)
        {
            return a + b + c;
        }
    }
}
