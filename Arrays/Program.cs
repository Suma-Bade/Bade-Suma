using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            //assign values
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            //accessing
            int k = a[2];
            Console.WriteLine(k);
            //display all array elements
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }

}
