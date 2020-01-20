using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArraysDemo1
    {
        static void Main()
        {
            int[] a = new int[3] { 60, 70, 80 };
            foreach (int i in a)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
