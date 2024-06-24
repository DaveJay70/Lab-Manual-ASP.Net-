using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Candidate
    {
        int Id, Age;
        String Name;
        double Weight, Height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter ID :-");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :-");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter Age :-");
            this.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Weight :-");
            this.Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Height :-");
            this.Height = Convert.ToDouble(Console.ReadLine());

        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("ID :- " + this.Id);
            Console.WriteLine("Name :- " + this.Name);
            Console.WriteLine("Age :- " + this.Age);
            Console.WriteLine("Weight :- " + this.Weight);
            Console.WriteLine("Height :- " + this.Height);
        }

    }
}

