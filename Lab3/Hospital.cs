using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: General hospital information.");
        }
    }
    internal class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospital: Specialized in Cardiology and Neurology.");

        }
    }
    internal class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Hospital: Known for its advanced Orthopedics and Cardiac care.");
        }
    }
    internal class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul Superspeciality Hospital: Renowned for its Oncology and Gastroenterology departments.");
        }
    }
}
