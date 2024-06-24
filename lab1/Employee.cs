using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    interface Gross
    {
        public Double Gross_Salary();
    }
    class Employee
    {
        public string Name;
        public double Basic_Salary;
        public void Basic_Sal()
        {
            Console.Write("Please enter Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Please enter Basic Salary: ");
            this.Basic_Salary = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Salary2 : Employee, Gross
    {
        double HRA, TA, DA;
        public Salary2()
        {
            Basic_Sal();
            Console.Write("Please Enter TA: ");
            TA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter DA: ");
            DA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter HRA: ");
            HRA = Convert.ToDouble(Console.ReadLine());
        }
        public Double Gross_Salary()
        {
            return (Basic_Salary + HRA + TA + DA);
        }
        public void Display_Salary()
        {
            Console.WriteLine("Name: {0}, Salary : {1}", Name, Gross_Salary());
        }
    }
}
