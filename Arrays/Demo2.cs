using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Demo2
    {
        static void Main()
        {
            int[] a = new int[4];
            //read array values from input
            for(int i=0;i<4;i++)
            {
                Console.WriteLine("enter a[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            //print values
            foreach (int k in a)
                Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
