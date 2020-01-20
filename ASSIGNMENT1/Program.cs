using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    class Program
    {
        public static void DisplayNum(int a,int b)
        {
            for(int i=a+1;i<b;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void EvenorOdd(int c)
        {
            if(c%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        public static void EvenOddCount(int d,int e)
        {
            int count = 0,count1 = 0,count2 = 0;
            for(int i=d;i<=e;i++)
            {
                if (i == 0)
                {
                    count++;
                }
                else if (i % 2 == 0)
                {
                    count1++;
                }
                else
                    count2++;
            }
            Console.WriteLine("even count=" + count1);
            Console.WriteLine("odd count=" + count2);

        }
        public static double Temp(double f)
        {
            double celsius = (f - 32)*5/9;
            return celsius;
           
        }
        public static void Squares(int g)
        {
            int h;
            for(int i=0;i<=g;i++)
            {
                h = i * i;
                Console.WriteLine(h);
            }
        }
        public static void Fact(int j)
        {
            int fact = 1;
            for(int k=1;k<=j;k++)
            {
                fact = fact * k;
                
            }
            Console.WriteLine(fact);
        }
        public static void Fib(int l)
        {
            int next, first=0, second=1;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for(int m=0;m<=l;m++)
            {
                next = first + second;
                first = second;
                second = next;
                Console.WriteLine(next);
            }
            

        }
        public static void Divisible(int n,int o)
        {
            for(int i=n;i<=o;i++)
            {
                if(i%7==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the world of C#");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name + "\n Welcome to the world of C#");
            Console.WriteLine("enter 2 num");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            DisplayNum(a,b);
            Console.WriteLine("enter a num to find even or odd");
            int c = int.Parse(Console.ReadLine());
            EvenorOdd(c);
            Console.WriteLine("enter 2 num to display count");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            EvenOddCount(d, e);
            Console.WriteLine("enter temp");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine(Temp(f));
            Console.WriteLine("enter a num to find squares");
            int g = int.Parse(Console.ReadLine());
            Squares(g);
            Console.WriteLine("enter a num to find factorial");
            int j = int.Parse(Console.ReadLine());
            Fact(j);
            Console.WriteLine("enter a num for fib series");
            int l = int.Parse(Console.ReadLine());
            Fib(l);
            int n = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            Divisible(n, o);



            Console.ReadKey();
        }
    }
}
