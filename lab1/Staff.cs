using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Staff
    {
        string Name, Department, Designation;
        double Experience, Salary;
        Staff[] staff = new Staff[2];

        public void getData()
        {

            for (int i = 0; i < staff.Length; i++)
            {
                staff[i] = new Staff();

                Console.WriteLine("Enter Name:: ");
                staff[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Department:: ");
                staff[i].Department = Console.ReadLine();


                Console.WriteLine("Enter Designation:: ");
                staff[i].Designation = Console.ReadLine();

                Console.WriteLine("Enter Experience::");
                staff[i].Experience = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void Display()
        {
            Console.WriteLine("Data is:: ");
            Console.WriteLine("=============");
            for (int i = 0; i < staff.Length; i++)
            {
                if (staff[i].Designation == "HOD")
                {
                    Console.WriteLine("Name is a :-"+staff[i].Name);
                    Console.WriteLine("Department is a :-"+staff[i].Department);
                }
            }
        }





    }
}
