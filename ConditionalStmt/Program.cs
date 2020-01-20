using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStmt
{
    class Program
    {
        public static string EvenorOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
        public static int Max(int i,int j,int k)
        {
            if(i>j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j > k)
                    return j;
                else
                    return k;
            }
        }
        public static string Result(double m1, double m2, double m3, double m4)
        {
            double average = (m1 + m2 + m3 + m4) / 4;
            if (average >= 70)
                return "distinction";
            else if (average >= 60 && average <= 70)
                return "First class with "+average+" %";
            else if (average >= 50 && average <= 60)
                return "Second class";
            else
                return "Fail";

        }


        static void Main(string[] args)
        {
            Console.WriteLine("enter a num");
            int i = int.Parse(Console.ReadLine());
            string result=EvenorOdd(i);
            Console.WriteLine(result);
            Console.WriteLine(Max(7,8,9));
            Console.WriteLine(Result(77.6, 33.4, 66.9, 77.23));
                Console.ReadKey();
            
        }
    }
}
