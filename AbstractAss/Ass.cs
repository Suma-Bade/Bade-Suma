using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAss
{
    class Ass
    {
        public static void Main(String[] args)
        {
            Undergrad ug = new Undergrad();
            Console.WriteLine("enter grade");
            int grade = int.Parse(Console.ReadLine());
            Console.WriteLine(""+( ug.Ispassed(grade)));
            Grad g = new Grad();
            Console.WriteLine("enter grade");
            int grade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("" + (g.Ispassed(grade2)));
            Console.ReadLine();
        }
    }
}
