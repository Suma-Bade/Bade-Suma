using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesWithDataTypes
{
    class Program
    {
        string name;//instance variable
        static double salary=35000;//static variable
        static void Main(string[] args)
        {
            int i=9;//local variable
            int[] a = new int[3] { 12, 22, 33 };
            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program( );
            Console.WriteLine(obj.name);
            object o1 = 100;
            o1 = "Rama";
            int k = 91;
            double Money = 100000.231;
            string name = "Suma";
            Console.WriteLine("Name:{0}\nAge:{1}\nMoney:{2}",name,k,Money);
            Console.ReadKey();
        }
    }
}
