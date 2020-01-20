using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAss
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger p = new Passenger("suma",20);
            Console.WriteLine("enter no of tickets");
            int num = int.Parse(Console.ReadLine());
            p.TicketBooking(num);
        }
    }
    public class TicketException:Exception
    {
        public TicketException(string s):base(s)
        {

        }
    }
   
    class Passenger
    {
        string name;
        int age;
        public Passenger(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void TicketBooking(int n)
            {

            try
            {
                if (n >= 2) throw new TicketException("can't book");
                else

                    Console.WriteLine("booking success");

            }
            catch(TicketException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
           
            Console.ReadLine();
        }
        
    }
}
