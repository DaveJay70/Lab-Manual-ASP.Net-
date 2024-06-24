using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Furniture
    {
        public String Material;
        public Double Price;
    }
    class Table : Furniture
    {
        int Height, Surface_Area;
        public void GetData()
        {
            Console.Write("Enter Material : ");
            Material = Console.ReadLine();
            Console.Write("Enter Price : ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter surface area: ");
            Surface_Area = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("\nMaterial : " + Material);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("Surface Area : " + Surface_Area);
        }
    }

}
