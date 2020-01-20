using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Demo3
    {
        static void Main()
        {
            string[] names = new string[5]
            {
                "sony",
                "dolly",
                "sweety",
                "sunny",
                "bunny"
            };
            int flag = 0;
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            foreach (string i in names)
            {
                if (s == i)
                {
                    flag = 1;

                    break;

                }
            }

            if (flag == 0)
                Console.WriteLine("exists");
            else
                Console.WriteLine("not exists");



            Console.ReadKey();
        }
        }
    }

