using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Salary
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;
        public double GrossSalary;

        public Salary()
        {
            DA = 0.1;
            HRA = 0.2;
            Console.WriteLine("Please enter basic salary : ");
            this.Basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter TA : ");
            this.TA = Convert.ToDouble(Console.ReadLine());
            GrossSalary = Basic + TA + HRA + DA;
        }
        public void Display()
        {
            Console.WriteLine("\nBasic salary : " + Basic);
            Console.WriteLine("Dearness allowence : " + DA);
            Console.WriteLine("Housing rent allowence : " + HRA);
            Console.WriteLine("Travelling allowence : " + TA);
            Console.WriteLine("Gross Salary : " + GrossSalary);
        }
    }
}
