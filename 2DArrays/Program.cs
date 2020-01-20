using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 3];
            for(int row=0;row<5;row++)
            {
                for(int column=0;column<3;column++)
                {
                    marks[row, column] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.WriteLine(""+marks[row, column]);
                }
                Console.WriteLine();
            }
            foreach (int x in marks)
                Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
