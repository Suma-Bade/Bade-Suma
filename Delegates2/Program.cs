using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            calAreaPointer cptr = new calAreaPointer(delegate (double r) { return 3.14 * r * r; });
            double area = cptr(12);
            Console.WriteLine(area);
            //above code is simplified with lambda
            calAreaPointer cptr1 = (r => 3.14 * r * r);
            double area1 = cptr1(10);
            Console.WriteLine(area1);
            Func<double, double> f1 = r => 3.14 * r * r;
            double area2 = f1(14);
            Console.WriteLine(area2);

            Action<string> act = (x => Console.WriteLine(x));
            act("welcome");
            Predicate<string> pt = (y => y.Length > 3);
            int[] array = new int[] { 1, 2, 3, 4 };
            List<string> names = new List<string>();
            names.Add("arun");
            names.Add("raj");
            names.Add("jai");
            int s = array.Count(x => x > 4);
            Console.WriteLine(s);
            List<string> sn = names.FindAll(y => y.Contains('y'));
            foreach (string n in sn)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(pt("cts"));

            Console.ReadLine();
        }
        //public static double calArea(double r)
        //{
        //    return 3.14 * r * r;
        //}
    }
    }
