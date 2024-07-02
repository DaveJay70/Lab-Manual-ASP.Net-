using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void Traficdel();

namespace Lab3
{
    internal class TrafficSignal
    {
        public void dt()
        {
            Traficdel t1 = new Traficdel(Yellow);
            Traficdel t2 = new Traficdel(Green);
            Traficdel t3 = new Traficdel(Red);
            t1.Invoke();
            t2.Invoke();
            t3.Invoke();
        }
        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }
        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }
        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }
    }
}
