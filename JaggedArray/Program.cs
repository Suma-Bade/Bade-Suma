﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] names = new string[3][];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter size of room"+(i+1));
                int size = int.Parse(Console.ReadLine());
                names[i] = new string[size];
            }
            Console.WriteLine("enter values");
            for(int row=0;row<3;row++)
            {
                for(int col=0;col<names[row].Length;col++)
                {
                    names[row][col] = Console.ReadLine();
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < names[row].Length; col++)
                {
                    Console.WriteLine("" + names[row][col]);
                }
            }
            Console.ReadKey();
        }
    }
}
