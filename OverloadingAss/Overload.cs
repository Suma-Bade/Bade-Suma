using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAss
{
     class Delivery
    { 
        public   void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("Bowler name : " + bowler + "\n Batsman Name : " + batsman);
        }
        public  void DisplayDeliveryDetails(long runs)
        {
            if(runs==6)
                {
                Console.WriteLine("It is a six");

            }
            else if(runs==4)
            {
                Console.WriteLine("it is a four");
            }
            else
            {
                Console.WriteLine("runs= " + runs);
            }

        }


    }
}
