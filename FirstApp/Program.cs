using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CTS");
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();//reads value from input
            Console.WriteLine("HEllo " + name);
            Console.ReadKey();//to read console output
        }
    }
}
