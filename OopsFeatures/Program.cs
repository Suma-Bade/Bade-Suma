using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsFeatures
{
    class Calculator
    {
        int val1;
        int val2;
        public int Val1
        {
            get => val1;set => val1 = value;
        }
        public int Val2
        {
            get => val2; set => val2 = value;
        }
        public  void Calculator2(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
        public void Add(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void Swap(int num1,int num2)//call by value
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
        public void Swap(ref int num1,ref int num2)//call by ref
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
        public void Subtract(int num1,int num2,out int result)
        {
            result = num1 - num2;
        }
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            cal.Add(x,y);
            cal.Subtract(x, y, out int result);
            Console.WriteLine(result);
            cal.Swap(x, y);
            cal.Swap(ref x, ref y);
            Console.ReadKey();
        }
    }
}
