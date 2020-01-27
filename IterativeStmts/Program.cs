using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeStmts
{
    class Program
    {
        public static void Greet(string name)
        {
            int flag = 1;
            while(flag<=10)
            {
                Console.WriteLine("Hello " + name);
                flag++;
            }
        }
        public static void NaturalNo(int i)
        {
            int flag = 1;
            while(flag<=i)
            {
                Console.Write(flag + " ");
                flag++;
            }
        }
        public static void WholeNum(int i)
        {
            int flag = 0;
            do
            {
                Console.Write( flag + "\t ");
                flag++;
            } while (flag <= i);
        }
        public static int Fact(int j)
        {
            int fact=1;
            // for (int i = 1; i <= j; i++)
            //{
            //  fact = fact * i;
            //}
            int i = 1;
            for(; ; )
            {
                if (i <= j)
                {
                    fact = fact * i;
                    i++;
                }
                else
                    break;
            }
            return fact;
        }
        public static void DisplayEven(int num)
        {
            for (int k = 1; k <= num;k++)
            {
                if (k % 2 == 1)
                    continue;
                Console.Write(k + " ");
            }
        }
        public static string CheckVowel(char ch)
        {
            string result = null;
            switch(ch)
            { 
                
                case 'i':
                    result = "Vowel";
                    break;
                case 'a':
                    result = "Vowel";
                    break;

                case 'e':
                    result = "Vowel";
                    break;

                case 'o':
                    result = "Vowel";
                    break;
                case 'u':
                    result = "Vowel";
                    break;
                default:
                    result = "invalid";
                    break;


            }
            return result;
        }
        public static void Menu(int s)
        {
            Console.WriteLine("enter your choice");
            int m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    if (s % 2 == 0)
                        Console.WriteLine("even");
                    else
                        Console.WriteLine("odd");
                    break;
                case 2:
                    int flag = 1;
                    while (flag <= s)
                    {
                        Console.Write(flag + " ");
                        flag++;
                    }
                    break;
                case 3:
                    for(int i=1;i<=10;i++)
                    {
                        int j;
                        j = s * i;
                        Console.WriteLine(s + "*" + i + "=" + j);
                    }
                    break;
                case 4:
                    break;


            }


        }
        static void Main(string[] args)
        {
            Greet("Suma");
            
            NaturalNo(100);
            WholeNum(70);
            Console.WriteLine(Fact(5));
            Console.WriteLine(CheckVowel('0'));
            Console.WriteLine("enter a num");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Even/odd\n2.Natural Num\n3.Multiplication\n4.Exit");
            Menu(s);
            Console.ReadKey();

        }
    }
}
