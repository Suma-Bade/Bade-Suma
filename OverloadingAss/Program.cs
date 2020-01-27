using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAss
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery d = new Delivery();
            Console.WriteLine("1.Players details of the delivery\n2.Run details of the delivery");
            Console.WriteLine("enter your choice");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:Console.WriteLine("enter bowler name");
                    string bowler = Console.ReadLine();
                    Console.WriteLine("enter batsmen name");
                    string batsman = Console.ReadLine();
                    d.DisplayDeliveryDetails(bowler,batsman);
                    break;
                case 2:Console.WriteLine("enter runs");
                    int runs = int.Parse(Console.ReadLine());
                    d.DisplayDeliveryDetails(runs);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            Console.ReadLine();
        }
    }
}
