using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "welcome";
            //Console.WriteLine(str.Length + " " + str.Replace("e", "k") + " " + str.ToLower());
            //Console.WriteLine(str.Contains("lc"));
            //Console.WriteLine( string.Compare("hello","Hello"));
            //string str2 = "WELCOME";
            //Console.WriteLine(str.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
            //string input = Console.ReadLine();
            //string[] data = input.Split(' ', '/');
            //int[] num2 = Array.ConvertAll(data, Convert.ToInt32);
            //int[] num = new int[data.Length];

            //for(int j=0;j<data.Length;j++)
            //{
            //    num[j] = Convert.ToInt32(data[0]);
            //}
            //foreach(string val in data)
            //{
            //    Console.WriteLine(val);
            //}
            //foreach(int val in num2)
            //{
            //    Console.WriteLine(val);
            //}
            //int k = 20;
            //double d = 2.32;
            //Console.WriteLine(k.ToString() + " " + d.ToString());
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.ToString("dddd/MMMM/yyyy") + " " + dt.ToString("dddd,dd/MM/yyyy") + "" + dt.ToString("MM/dd/yyyy\t HH:mm:ss"));
            //int[] ix = new int[] { 1, 2, 3, 4 };
            Employee[] eArray = new Employee[3] { new Employee("arun", "100", 21000), new Employee("raj", "200", 12000), new Employee("tej", "300", 30000) };
            foreach(Employee e in eArray)
            {
                Console.WriteLine(e.ToString());
            }
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("rama", "400", 12099));
            elist.Add(new Employee("ram", "500", 19099));
            elist.Add(new Employee("sita", "600", 17099));
            foreach(Employee e in elist)
            {
                Console.WriteLine(e.ToString());
            }
            Employee e1 = new Employee("siri", "700", 20000);
            Employee e2 = new Employee("siri", "700", 20000);
            if(e1.Equals(e2))
            {
                Console.WriteLine("same");

            }
            else
            {
                Console.WriteLine("unequal");
            }

            Console.ReadLine();
        

        }
    }
}
