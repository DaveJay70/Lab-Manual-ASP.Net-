using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Student
    {
        int Enrollment;
        String Name;
        int Semester;
        double CPI;
        double SPI;

        public Student()
        {

            Console.WriteLine("Enter Enrollment :-");
            this.Enrollment = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :-");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter Semester :-");
            this.Semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter CPI :-");
            this.CPI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter SPI :-");
            this.SPI = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Enrollment is a :-"+this.Enrollment);
            Console.WriteLine("Name is a :-" + this.Name);
            Console.WriteLine("Semester is a :-" + this.Semester);
            Console.WriteLine("Cpi is a :-" + this.CPI);
            Console.WriteLine("Spi is a :-" + this.SPI);
        }
    }
}
